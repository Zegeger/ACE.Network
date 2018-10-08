using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACE.Network.Packets;
using ACE.Network.Enums;
using System.Net;
using ACE.Network.Messages;

namespace ACE.Network
{
    /// <summary>
    /// IN PROGRESS
    /// </summary>
    public class BaseNetworkSession
    {
        public IPEndPoint IPAddress { get; }
        public uint RecId { get; }
        public ushort Iteration { get; }
        public double Timestamp { get; }

        public ConnectionState State { get; protected set; }

        public Dictionary<Queues, Queue<Message>> NetQueues { get; } = new Dictionary<Queues, Queue<Message>>();

        protected Defragmenter defragmenter;

        private ushort currentRemoteInterval = 0;
        private uint bytesReceived = 0;

        Dictionary<ulong, ArrivedEphInfo> arrivedEphemeralBlobs = new Dictionary<ulong, ArrivedEphInfo>();

        protected BaseNetworkSession(IPEndPoint ip, uint recId, NetworkType type)
        {
            IPAddress = ip;
            RecId = recId;
            defragmenter = new Defragmenter(type == NetworkType.Server ? MessageDirection.ClientToServer : MessageDirection.ServerToClient);
            defragmenter.NewMessage += Defragmenter_NewMessage;
        }

        private void Defragmenter_NewMessage(object sender, NewMessageEventArgs e)
        {
            if(NetQueues.ContainsKey(e.Message.MessageQueue))
            {
                NetQueues[e.Message.MessageQueue].Enqueue(e.Message);
            }
        }

        protected virtual bool VerifyPacket(Packet p)
        {
            return true;
        }

        public virtual void ProcessPacket(Packet p)
        {
            if (!VerifyPacket(p))
                return;
            if(currentRemoteInterval == 0 || p.Interval.IsNewer(currentRemoteInterval))
            {
                ProcessNewRemoteInterval(p);
            }
            bytesReceived += p.DataLen + 20u;
            ProcessOptionalHeaders(p);
            if (p.Header.HasFlag(PacketHeaderFlags.BlobFragments) && p.Fragments.Count > 0)
            {
                ProcessFrags(p);
            }
        }

        private void ProcessNewRemoteInterval(Packet p)
        {
            if(currentRemoteInterval > 0)
            {
                var flow = new Packets.Headers.Flow();
                flow.BytesReceived = bytesReceived;
                flow.Interval = currentRemoteInterval;
                //EnqueueOptionalHeader(flow);
            }
            currentRemoteInterval = p.Interval;
            bytesReceived = 0;
        }

        private void RemoveObsoleteEphemerals(Packet p)
        {
            List<BlobFrag> removalList = new List<BlobFrag>();
            foreach(var frag in p.Fragments)
            {
                if (frag.IsEphemeral)
                {
                    ArrivedEphInfo aei = null;
                    if (arrivedEphemeralBlobs.TryGetValue(frag.BlobSequenceId, out aei))
                    {
                        if(aei.LastNetBlobID != frag.NetBlobId)
                        {
                            if(aei.LastNetBlobID.OrderingStamp.IsNewer(frag.NetBlobId.OrderingStamp))
                            {
                                removalList.Add(frag);
                            }
                            else
                            {
                                aei.UpdateNetBlobId(frag.NetBlobId);
                            }
                        }
                    }
                    else
                    {
                        ArrivedEphInfo newAei = new ArrivedEphInfo(frag.BlobSequenceId, frag.NetBlobId);
                        arrivedEphemeralBlobs.Add(frag.BlobSequenceId, newAei);
                    }
                }
            }
            foreach (var x in removalList)
                p.Fragments.Remove(x);
        }

        private void ProcessFrags(Packet p)
        {
            RemoveObsoleteEphemerals(p);
            defragmenter.ProcessPacket(p);
        }

        protected virtual bool ProcessOptionalHeaders(Packet p)
        {
            if (p.Header <= PacketHeaderFlags.CloseConnection)
            {
                if (p.Header.HasFlag(PacketHeaderFlags.CloseConnection))
                {
                    State = ConnectionState.DisconnectReceived;
                    return true;
                }
                if (p.Header.HasFlag(PacketHeaderFlags.NegativeAck))
                {
                    //HandleNaks();
                    return true;
                }
                if (p.Header.HasFlag(PacketHeaderFlags.EmptyAck))
                {
                    //HandleEmptyAcks();
                    return true;
                }
                if (p.Header.HasFlag(PacketHeaderFlags.PositiveAck))
                {
                    //HandlPaks();
                    return true;
                }
                return false;
            }
            if (p.Header.HasFlag(PacketHeaderFlags.TimeSync))
            {
                //HandleTimeSync();
            }
            else
            {
                if (p.Header.HasFlag(PacketHeaderFlags.EchoRequest))
                {
                    //HandleEchoRequest();
                    return true;
                }
                if (p.Header != PacketHeaderFlags.EchoResponse)
                    return false;
            }
            return true;
        }

        private void ProcessNewSeqNum(Packet p)
        {
            
        }
    }
}

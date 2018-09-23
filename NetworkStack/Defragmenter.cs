using System;
using System.Collections.Generic;
using System.Text;
using ACE.Network.Packets;
using ACE.Network.Messages;
using System.IO;
using log4net;
using System.Diagnostics;

namespace ACE.Network
{
    /// <summary>
    /// Class to take AC Packets and extract messages from them.  Each message can be broken across multiple packets, or a single packet can contain multiple messages.
    /// </summary>
    public class Defragmenter
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// List of partially completed messages
        /// </summary>
        Dictionary<ulong, NetBlob> partialBlobs = new Dictionary<ulong, NetBlob>();

        /// <summary>
        /// Event raised when a new Message is completed.
        /// </summary>
        public event EventHandler<NewMessageEventArgs> NewMessage;

        /// <summary>
        /// Direction of the defragmenter
        /// </summary>
        private MessageDirection Direction { get; }

        public Defragmenter(MessageDirection direction)
        {
            Direction = direction;
        }

        /// <summary>
        /// Processes a Packet, reading all Fragments and matching them to pending blobs, raising an event when a completed message is found.
        /// </summary>
        /// <param name="p"></param>
        public void ProcessPacket(Packet p)
        {
            log.DebugFormat("Processing packet {0}", p.SeqID);
            foreach(BlobFrag frag in p.Fragments)
            {
                log.DebugFormat("Processing Fragment {0}", frag.BlobSequenceId);
                NetBlob netBlob = null;
                if(partialBlobs.ContainsKey(frag.BlobSequenceId))
                {
                    log.DebugFormat("Adding Fragment {0} to partial NetBlob", frag.BlobSequenceId);
                    netBlob = partialBlobs[frag.BlobSequenceId];
                    netBlob.AddFrag(frag);
                    if (netBlob.IsComplete)
                        partialBlobs.Remove(frag.BlobSequenceId);
                }
                else
                {
                    log.DebugFormat("Creating new NetBlob with Fragment {0}", frag.BlobSequenceId);
                    netBlob = new NetBlob(frag);
                    if (!netBlob.IsComplete)
                        partialBlobs.Add(frag.BlobSequenceId, netBlob);
                }
                if(netBlob.IsComplete)
                {
                    log.DebugFormat("NetBlob {0} is complete", frag.BlobSequenceId);
                    using (MemoryStream stream = new MemoryStream(netBlob.GetCompletedData()))
                    {
                        using (BinaryReader reader = new BinaryReader(stream))
                        {
                            Message message;
                            if (Direction == MessageDirection.ClientToServer)
                                message = Message.ReadC2SMessage(reader);
                            else
                                message = Message.ReadS2CMessage(reader);
#if NETWORKDEBUG
                            message.NetworkPacketNums.AddRange(netBlob.NetworkPacketNums);
#endif
                            NewMessage?.Invoke(this, new NewMessageEventArgs(message));
                        }
                    }
                }
            }
        }
    }
}

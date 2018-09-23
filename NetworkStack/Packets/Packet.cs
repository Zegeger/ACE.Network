using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Types;
using ACE.Network.Extensions;
using ACE.Network.Packets.Headers;
using System.Net;
using log4net;

namespace ACE.Network.Packets
{
    /// <summary>
    /// Basic packet structure for all communication packets between the client and server.
    /// </summary>
    public class Packet
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly ILog packetLog = LogManager.GetLogger(System.Reflection.Assembly.GetCallingAssembly(), "Packets");

        public static readonly uint PacketHeaderSize = 20;
        public static readonly uint MaxPacketSize = 484;

        /// <summary>
        /// IPAddress that sent the packet
        /// </summary>
        public IPEndPoint IPAddress { get; }
        
        /// <summary>
        /// Sequence number for the packet
        /// </summary>
        public uint SeqID { get; set; }

        /// <summary>
        /// Bitmask identifiying the content/options on the packet
        /// </summary>
        public PacketHeaderFlags Header { get; set; }

        /// <summary>
        /// CRC value for verifying the content of the packet
        /// </summary>
        public uint Checksum { get; set; }

        /// <summary>
        /// Recipient id, must be less than or equal to 0x100
        /// </summary>
        public ushort RecId { get; set; }

        /// <summary>
        /// Something to do with flow management.  1 interval seems to be 1/2 a second.  Client sends TimeSynch and EchoRequest every 6 intervals.  It sends CICMD every 220.
        /// </summary>
        public ushort Interval { get; set; }

        /// <summary>
        /// Length of data in the packet, excluding this Header
        /// </summary>
        public ushort DataLen { get; set; }

        /// <summary>
        /// An id for the current session with a particular world server.  Will increase each time we leave and then return to a particular server, receiving a new ConnectRequest.
        /// </summary>
        public ushort Iteration { get; set; }

        public ServerSwitch ServerSwitchData { get; } = new ServerSwitch();

        public Referral ReferralData { get; } = new Referral();

        public Nak NegativeAckData { get; } = new Nak();

        public EmptyAck EmptyAckData { get; } = new EmptyAck();

        public Pak PositiveAckData { get; } = new Pak();

        public LoginRequest LoginRequestData { get; } = new LoginRequest();

        public ServerSwitchRequest ServerSwitchRequestData { get; } = new ServerSwitchRequest();

        public ConnectRequest ConnectRequestData { get; } = new ConnectRequest();

        public ConnectAck ConnectResponseData { get; } = new ConnectAck();

        public NetError NetErrorData { get; } = new NetError();

        public CloseConnection CloseConnectionData { get; } = new CloseConnection();

        public CICMDCommand CicmdData { get; } = new CICMDCommand();

        public TimeSync TimeSyncData { get; } = new TimeSync();

        public EchoRequest EchoRequestData { get; } = new EchoRequest();

        public EchoResponse EchoResponseData { get; } = new EchoResponse();

        public Flow FlowData { get; } = new Flow();
        
        /// <summary>
        /// List of fragments.  Variable length, fragment Header defines the length.
        /// </summary>
        public List<BlobFrag> Fragments { get; } = new List<BlobFrag>();
        
        public Packet(IPEndPoint ip)
        {
            IPAddress = ip;
        }

        public Packet(byte[] bytes, IPEndPoint ip) : this(ip)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    Unpack(br);
                }
            }
        }

#if NETWORKDEBUG
        public ulong NetworkPacketNum { get; }

        public Packet(byte[] bytes, IPEndPoint ip, ulong networkPacketNum) : this(ip)
        {
            NetworkPacketNum = networkPacketNum;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    Unpack(br);
                }
            }
        }
#endif

        public void Unpack(BinaryReader reader)
        {
            var bytesRemaining = reader.BytesRemaining();
            log.DebugFormat("Unpack bytes: {0}", bytesRemaining);
            log.Assert(bytesRemaining >= PacketHeaderSize, "Packet size too small");
            log.Assert(bytesRemaining <= MaxPacketSize, "Packet size too big");

            SeqID = reader.ReadUInt32();
            Header = (PacketHeaderFlags)reader.ReadUInt32();
            Checksum = reader.ReadUInt32();
            RecId = reader.ReadUInt16();
            Interval = reader.ReadUInt16();
            DataLen = reader.ReadUInt16();
            Iteration = reader.ReadUInt16();

            log.DebugFormat("SeqID: {0}, Header: {1}, Checksum {2}, RecId: {3}, Interval {4}, DataLen: {5}, Iteration: {6}", SeqID, Header, Checksum, RecId, Interval, DataLen, Iteration);

            bytesRemaining = reader.BytesRemaining();
#if NETWORKVALIDATION
            log.Assert(bytesRemaining == DataLen, "Size of reader " + DataLen + " does not equal packet length: " + bytesRemaining );
#endif

            if ((Header & PacketHeaderFlags.ServerSwitch) != 0)
            {
                ServerSwitchData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.Referral) != 0)
            {
                ReferralData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.NegativeAck) != 0)
            {
                NegativeAckData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.EmptyAck) != 0)
            {
                EmptyAckData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.PositiveAck) != 0)
            {
                PositiveAckData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.LoginRequest) != 0)
            {
                LoginRequestData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.ServerSwitchRequest) != 0)
            {
                ServerSwitchRequestData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.ConnectRequest) != 0)
            {
                ConnectRequestData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.ConnectResponse) != 0)
            {
                ConnectResponseData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.NetError) != 0)
            {
                NetErrorData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.CloseConnection) != 0)
            {
                CloseConnectionData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.CICMDCommand) != 0)
            {
                CicmdData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.TimeSync) != 0)
            {
                TimeSyncData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.EchoRequest) != 0)
            {
                EchoRequestData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.EchoResponse) != 0)
            {
                EchoResponseData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.Flow) != 0)
            {
                FlowData.Unpack(reader);
            }
            if((Header & PacketHeaderFlags.BlobFragments) != 0)
            {
                log.Debug("Reading Blob Fragments");
                Fragments.Clear();
                bytesRemaining = reader.BytesRemaining();
                uint fragNum = 0;
                while ( bytesRemaining >= 16)
                {
                    log.DebugFormat("Bytes Remaining: {0}", bytesRemaining);
                    BlobFrag newItem = new BlobFrag(reader);
#if NETWORKDEBUG
                    newItem.NetworkPacketNum = NetworkPacketNum;
                    newItem.NetworkFragmentNum = ++fragNum;
#endif
                    Fragments.Add(newItem);
                    bytesRemaining = reader.BytesRemaining();
                }
#if NETWORKVALIDATION
                log.Assert(bytesRemaining == 0, "Bytes still remaining in packet: " + bytesRemaining);
#endif
            }

        }

        public void Pack(BinaryWriter writer)
        {
            log.Debug("Pack");
            writer.Write(SeqID);
            writer.Write((uint)Header);
            writer.Write(Checksum);
            writer.Write(RecId);
            writer.Write(Interval);
            writer.Write(DataLen);
            writer.Write(Iteration);
            if((Header & PacketHeaderFlags.ServerSwitch) != 0)
            {
                ServerSwitchData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.Referral) != 0)
            {
                ReferralData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.NegativeAck) != 0)
            {
                NegativeAckData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.EmptyAck) != 0)
            {
                EmptyAckData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.PositiveAck) != 0)
            {
                PositiveAckData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.LoginRequest) != 0)
            {
                LoginRequestData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.ServerSwitchRequest) != 0)
            {
                ServerSwitchRequestData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.ConnectRequest) != 0)
            {
                ConnectRequestData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.ConnectResponse) != 0)
            {
                ConnectResponseData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.NetError) != 0)
            {
                NetErrorData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.CloseConnection) != 0)
            {
                CloseConnectionData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.CICMDCommand) != 0)
            {
                CicmdData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.TimeSync) != 0)
            {
                TimeSyncData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.EchoRequest) != 0)
            {
                EchoRequestData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.EchoResponse) != 0)
            {
                EchoResponseData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.Flow) != 0)
            {
                FlowData.Pack(writer);
            }
            if((Header & PacketHeaderFlags.BlobFragments) != 0)
            {
                foreach(var fragment in Fragments)
                {
                    fragment.Pack(writer);
                }
            }

        }
    }
}

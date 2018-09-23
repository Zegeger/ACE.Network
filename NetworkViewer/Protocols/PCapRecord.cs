using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ACE.Network.Tools.NetworkViewer.Protocols
{
    public class PCapRecord
    {
        DateTime TimeStamp { get; }
        public uint TsSec { get; }
        public uint TsUsec { get; }
        public uint InclLen { get; }
        public uint OrigLen { get; }
        public EthernetPacket EthernetPacket { get; }
        public ulong PacketNum { get; }

        public PCapRecord(BinaryReader binaryReader, ulong packetNum = 0)
        {
            PacketNum = packetNum;
            TsSec = binaryReader.ReadUInt32();
            TsUsec = binaryReader.ReadUInt32();
            var dt = DateTimeOffset.FromUnixTimeMilliseconds((long)TsSec * 1000 + (long)TsUsec / 1000);
            TimeStamp = dt.UtcDateTime;
            InclLen = binaryReader.ReadUInt32();
            OrigLen = binaryReader.ReadUInt32();
            var body = binaryReader.ReadBytes((int)InclLen);
            using (MemoryStream bodyStream = new MemoryStream(body))
            {
                using (BinaryReader bodyReader = new BinaryReader(bodyStream))
                {
                    EthernetPacket = new EthernetPacket(bodyReader, InclLen);
                }
            }
        }
    }
}

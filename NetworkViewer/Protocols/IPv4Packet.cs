using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools.NetworkViewer.Protocols
{
    public class IPv4Packet : IEtherType
    {
        public byte VerIhl { get; }
        public byte Tos { get; }
        public ushort TLen { get; }
        public ushort Identification { get; }
        public ushort FlagsFo { get; }
        public byte Ttl { get; }
        public IPProtocolType Proto { get; }
        public ushort Crc { get; }
        public Ipv4Address SrcAddr { get; }
        public Ipv4Address DestAddr { get; }

        public IIPProtocol Data { get; }

        public IPv4Packet(BinaryReader binaryReader, uint Length)
        {
            VerIhl = binaryReader.ReadByte();
            Tos = binaryReader.ReadByte();
            TLen = binaryReader.ReadUInt16();
            Identification = binaryReader.ReadUInt16();
            FlagsFo = binaryReader.ReadUInt16();
            Ttl = binaryReader.ReadByte();
            Proto = (IPProtocolType)binaryReader.ReadByte();
            Crc = binaryReader.ReadUInt16();
            SrcAddr = new Ipv4Address(binaryReader);
            DestAddr = new Ipv4Address(binaryReader);

            if(Proto == IPProtocolType.UDP) // UDP
            {
                Data = new UdpPacket(binaryReader, Length);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools.NetworkViewer.Protocols
{
    public class UdpPacket : IIPProtocol
    {
        public ushort SrcPort { get; }
        public ushort DestPort { get; }
        public ushort Len { get; }
        public ushort Crc { get; }
        public byte[] Data { get; }

        public UdpPacket(BinaryReader binaryReader, uint Length)
        {
            SrcPort = BitConverter.ToUInt16(Util.ReverseBytes(binaryReader.ReadBytes(2)), 0);
            DestPort = BitConverter.ToUInt16(Util.ReverseBytes(binaryReader.ReadBytes(2)), 0);
            Len = BitConverter.ToUInt16(Util.ReverseBytes(binaryReader.ReadBytes(2)), 0);
            Crc = BitConverter.ToUInt16(Util.ReverseBytes(binaryReader.ReadBytes(2)), 0);
            if (Length != Len)
            {
                Len = (ushort)(Length - 34);
            }
            Data = binaryReader.ReadBytes(Len - 8);
        }
    }
}

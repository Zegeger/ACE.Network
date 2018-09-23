using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools.NetworkViewer.Protocols
{
    public class EthernetPacket
    {
        public MACAddress Dest;
        public MACAddress Source;
        public EtherType Proto;

        public IEtherType Data;

        public EthernetPacket(BinaryReader binaryReader, uint Length)
        {
            Dest = new MACAddress(binaryReader);
            Source = new MACAddress(binaryReader);
            Proto = (EtherType)BitConverter.ToUInt16(Util.ReverseBytes(binaryReader.ReadBytes(2)), 0);

            if (Proto == EtherType.IPv4) // IPv4
            {
                Data = new IPv4Packet(binaryReader, Length);
            }
            else if (Proto == EtherType.IPv6) // IPv6
            {

            }

        }
    }
}

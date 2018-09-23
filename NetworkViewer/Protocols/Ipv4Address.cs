using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools.NetworkViewer.Protocols
{
    public class Ipv4Address
    {
        public byte Octet0 { get; }
        public byte Octet1 { get; }
        public byte Octet2 { get; }
        public byte Octet3 { get; }

        public Ipv4Address(BinaryReader binaryReader)
        {
            Octet0 = binaryReader.ReadByte();
            Octet1 = binaryReader.ReadByte();
            Octet2 = binaryReader.ReadByte();
            Octet3 = binaryReader.ReadByte();
        }

        public long LongAddress
        {
            get
            {
                uint rtn = Octet3;
                rtn |= (uint)(Octet2 << 8);
                rtn |= (uint)(Octet1 << 16);
                rtn |= (uint)(Octet0 << 24);
                return rtn;
            }
        }
        
        public bool IsLocal
        {
            get
            {
                return (Octet0 == 10) || (Octet0 == 172 && Octet1 >= 16 && Octet1 <= 31) || (Octet0 == 192 && Octet1 == 168) ||
                    (Octet0 == 127 && Octet1 == 0 && Octet2 == 0 && Octet3 == 1);
            }
        }

        public override string ToString()
        {
            return String.Format("{0}.{1}.{2}.{3}", Octet0, Octet1, Octet2, Octet3);
        }
    }
}

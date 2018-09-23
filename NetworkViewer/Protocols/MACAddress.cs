using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools.NetworkViewer.Protocols
{
    public class MACAddress
    {
        public byte Octet0 { get; }
        public byte Octet1 { get; }
        public byte Octet2 { get; }
        public byte Octet3 { get; }
        public byte Octet4 { get; }
        public byte Octet5 { get; }

        public MACAddress(BinaryReader binaryReader)
        {
            Octet0 = binaryReader.ReadByte();
            Octet1 = binaryReader.ReadByte();
            Octet2 = binaryReader.ReadByte();
            Octet3 = binaryReader.ReadByte();
            Octet4 = binaryReader.ReadByte();
            Octet5 = binaryReader.ReadByte();
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}:{2}:{3}:{4}:{5}", Octet0, Octet1, Octet2, Octet3, Octet4, Octet5);
        }
    }
}

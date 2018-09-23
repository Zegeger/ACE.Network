using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools.NetworkViewer.Protocols
{
    public enum EtherType : ushort
    {
        IPv4 = 0x800,
        IPv6 = 0x86DD
    }
}

using ACE.Network.Tools.NetworkViewer.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools.NetworkViewer.Protocols
{
    public class PacketReadEventArgs
    {
        public PCapRecord PacketRecord { get; private set; }

        public PacketReadEventArgs(PCapRecord record)
        {
            PacketRecord = record;
        }
    }
}

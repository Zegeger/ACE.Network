using ACE.Network.Packets;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network
{
    class ArrivedEphInfo
    {
        public ulong Sequence { get; }
        public BlobFragSequence LastNetBlobID { get; private set; }
        public DateTime Timestamp { get; private set; }

        public ArrivedEphInfo(ulong sequence, BlobFragSequence netblob)
        {
            Sequence = sequence;
            LastNetBlobID = netblob;
            Timestamp = DateTime.Now;
        }
        
        public void UpdateNetBlobId(BlobFragSequence netblob)
        {
            LastNetBlobID = netblob;
            Timestamp = DateTime.Now;
        }
    }
}

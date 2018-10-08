using ACE.Network.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network.Packets
{
    public class BlobFragSequence
    {
        private ulong rawValue;
        public ulong RawValue
        {
            get
            {
                return rawValue;
            }
            private set
            {
                rawValue = value;
                SequenceID = (uint)rawValue;
                OrderingStamp = (ushort)(rawValue >> 32);
                ServerID = (byte)(rawValue >> 48);
                EventType = (SequenceFlags)(rawValue >> 56);
            }
        }
        /// <summary>
        /// For non-ephemeral messages, this appears to just count up.  For ephemeral messages, this stays the same (for the same objectID and same message type?), and the orderingStamp defines the sequence.
        /// </summary>
        public uint SequenceID { get; private set; }

        /// <summary>
        /// This appears to count up for all message types.
        /// </summary>
        public ushort OrderingStamp { get; private set; }

        /// <summary>
        /// This should match the id from the packet header for server to client.  Client seems to leave this 0.
        /// </summary>
        public byte ServerID { get; private set; }

        /// <summary>
        /// Flag values identifying the message properties
        /// </summary>
        public SequenceFlags EventType { get; private set; }

        public BlobFragSequence(ulong value)
        {
            RawValue = value;
        }
    }
}

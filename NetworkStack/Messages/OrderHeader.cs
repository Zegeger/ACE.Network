using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network.Messages
{
    public class OrderedHeader
    {
        uint? ObjectId { get; }
        uint Sequence { get; }

        public OrderedHeader(uint sequence)
        {
            Sequence = sequence;
        }

        public OrderedHeader(uint objectId, uint sequence)
        {
            ObjectId = objectId;
            Sequence = sequence;
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Types;
using ACE.Network.Extensions;

namespace ACE.Network.Messages
{
    public abstract class OrderedMessage : Message
    {
        public  OrderedHeader OrderHeader { get; internal set; }

        protected OrderedMessage(MessageType type, MessageDirection direction, Queues queue) : base(type, direction, queue, true)
        {
            
        }
    }
}

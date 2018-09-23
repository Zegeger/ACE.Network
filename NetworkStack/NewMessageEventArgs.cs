using System;
using System.Collections.Generic;
using System.Text;
using ACE.Network.Messages;

namespace ACE.Network
{
    /// <summary>
    /// Event args used when new messages are raised from a Defragmenter
    /// </summary>
    public class NewMessageEventArgs
    {
        public Message Message { get; }

        public NewMessageEventArgs(Message message)
        {
            Message = message;
        }
    }
}

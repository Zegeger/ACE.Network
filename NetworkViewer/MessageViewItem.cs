using ACE.Network.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools
{
    /// <summary>
    /// Item for display in UI list.
    /// </summary>
    class MessageViewItem
    {
        public string FileName { get; }
        public Message Message { get; }

        public MessageViewItem(string fileName, Message message)
        {
            FileName = fileName;
            Message = message;
        }
    }
}

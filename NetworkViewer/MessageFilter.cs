using ACE.Network.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools
{
    /// <summary>
    /// This class manages the current message filter, raising an event when it changes.
    /// This is passed into and stored in each NetworkTrace instance.  Each NetworkTrace subscribes to FilterChanged so it can update its list of filtered messages if the filter changes.
    /// The filter is currently only based on a message type value, but more complex filtering could be done in the future.
    /// </summary>
    class MessageFilter
    {
        private int messageType = 0;

        /// <summary>
        /// Current message type filter to apply.  0 value indicates unfiltered.
        /// </summary>
        public int MessageType {
            get
            {
                return messageType;
            }

            set
            {
                messageType = value;
                FilterChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Event raised when the filter has changed.
        /// </summary>
        public event EventHandler FilterChanged;

        public MessageFilter()
        {

        }

        /// <summary>
        /// Checks a specific message to determine if it meets the filter criteria.
        /// </summary>
        /// <param name="message">Message object to check</param>
        /// <returns>True if the message meets the filter criteria</returns>
        public bool CheckMessage(Message message)
        {
            // Zero indicates unfiltered, otherwise the message type must match.
            if(messageType == 0 || (int)message.MessageType == messageType)
            {
                return true;
            }
            return false;
        }
    }
}

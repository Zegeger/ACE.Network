using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network
{
    /// <summary>
    /// Attribute used to identify which properties are unique to a given message.  Used to dynamically read the message properties through reflection.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class MessageProperty : Attribute
    {
        public MessageProperty()
        {

        }
    }
}

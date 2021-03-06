////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Types;
using ACE.Network.Extensions;

namespace ACE.Network.Messages
{
    /// <summary>
    /// HandleEvasionAttackerNotificationEvent: Your target has evaded your melee attack.
    /// </summary>
    public class HandleEvasionAttackerNotificationEventS2C : OrderedMessage
    {
        /// <summary>
        /// the name of your target
        /// </summary>
        [MessageProperty]
        public string DefendersName { get; set; }        
        


        public HandleEvasionAttackerNotificationEventS2C() : base((MessageType)0x01B3, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HandleEvasionAttackerNotificationEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            DefendersName = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(DefendersName);

        }


    }
}

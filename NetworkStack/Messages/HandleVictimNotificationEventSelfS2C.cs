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
    /// You just died.
    /// </summary>
    public class HandleVictimNotificationEventSelfS2C : OrderedMessage
    {
        /// <summary>
        /// Your (typically mocking) death message.
        /// </summary>
        [MessageProperty]
        public string Msg { get; set; }        
        


        public HandleVictimNotificationEventSelfS2C() : base((MessageType)0x01AC, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HandleVictimNotificationEventSelfS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Msg = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Msg);

        }


    }
}

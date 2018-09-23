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
    /// HandleEvasionDefenderNotificationEvent: You have evaded a creature's melee attack.
    /// </summary>
    public class HandleEvasionDefenderNotificationEventS2C : OrderedMessage
    {
        /// <summary>
        /// the name of the creature
        /// </summary>
        [MessageProperty]
        public string AttackersName { get; set; }        
        


        public HandleEvasionDefenderNotificationEventS2C() : base((MessageType)0x01B4, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HandleEvasionDefenderNotificationEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            AttackersName = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(AttackersName);

        }


    }
}

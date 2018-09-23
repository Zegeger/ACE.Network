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
    /// Adds a guest to your house guest list
    /// </summary>
    public class AddPermanentGuestC2S : OrderedMessage
    {
        /// <summary>
        /// Player name to add to your house guest list
        /// </summary>
        [MessageProperty]
        public string GuestName { get; set; }        
        


        public AddPermanentGuestC2S() : base((MessageType)0x0245, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public AddPermanentGuestC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            GuestName = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(GuestName);

        }


    }
}

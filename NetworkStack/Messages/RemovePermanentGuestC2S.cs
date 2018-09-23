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
    /// Removes a specific player from your house guest list, /house guest remove
    /// </summary>
    public class RemovePermanentGuestC2S : OrderedMessage
    {
        /// <summary>
        /// Player name to remove from your house guest list
        /// </summary>
        [MessageProperty]
        public string GuestName { get; set; }        
        


        public RemovePermanentGuestC2S() : base((MessageType)0x0246, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public RemovePermanentGuestC2S(BinaryReader reader) : this()
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

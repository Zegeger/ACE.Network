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
    /// Boots a specific player from your house /house boot
    /// </summary>
    public class BootSpecificHouseGuestC2S : OrderedMessage
    {
        /// <summary>
        /// Player name to boot from your house
        /// </summary>
        [MessageProperty]
        public string GuestName { get; set; }        
        


        public BootSpecificHouseGuestC2S() : base((MessageType)0x024A, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public BootSpecificHouseGuestC2S(BinaryReader reader) : this()
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

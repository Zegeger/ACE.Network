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
    /// Changes a specific players storage permission, /house storage add/remove
    /// </summary>
    public class ChangeStoragePermissionC2S : OrderedMessage
    {
        /// <summary>
        /// Player name to boot from your house
        /// </summary>
        [MessageProperty]
        public string GuestName { get; set; }        
        
        /// <summary>
        /// Whether the player has permission on your storage
        /// </summary>
        [MessageProperty]
        public bool HasPermission { get; set; }        
        


        public ChangeStoragePermissionC2S() : base((MessageType)0x0249, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ChangeStoragePermissionC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            GuestName = reader.ReadString16L();
            HasPermission = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(GuestName);
            writer.WriteBool32(HasPermission);

        }


    }
}

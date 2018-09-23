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
    /// Modify whether allegiance members are guests, /house guest add_allegiance/remove_allegiance
    /// </summary>
    public class ModifyAllegianceGuestPermissionC2S : OrderedMessage
    {
        /// <summary>
        /// Whether we are adding or removing permissions
        /// </summary>
        [MessageProperty]
        public bool Add { get; set; }        
        


        public ModifyAllegianceGuestPermissionC2S() : base((MessageType)0x0267, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ModifyAllegianceGuestPermissionC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Add = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteBool32(Add);

        }


    }
}

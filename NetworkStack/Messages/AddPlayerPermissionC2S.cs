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
    /// Grants a player corpse looting permission, /permit add
    /// </summary>
    public class AddPlayerPermissionC2S : OrderedMessage
    {
        /// <summary>
        /// Name of player to grant permission to loot the playes corpses
        /// </summary>
        [MessageProperty]
        public string TargetName { get; set; }        
        


        public AddPlayerPermissionC2S() : base((MessageType)0x0219, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public AddPlayerPermissionC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            TargetName = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(TargetName);

        }


    }
}

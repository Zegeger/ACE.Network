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
    /// Equip an item.
    /// </summary>
    public class WearItemS2C : OrderedMessage
    {
        /// <summary>
        /// the object ID of the item being equipped
        /// </summary>
        [MessageProperty]
        public uint ItemID { get; set; }        
        
        /// <summary>
        /// the slot(s) the item uses
        /// </summary>
        [MessageProperty]
        public EquipMask Slot { get; set; }        
        


        public WearItemS2C() : base((MessageType)0x0023, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public WearItemS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ItemID = reader.ReadUInt32();
            Slot = (EquipMask)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ItemID);
            writer.Write((uint)Slot);

        }


    }
}

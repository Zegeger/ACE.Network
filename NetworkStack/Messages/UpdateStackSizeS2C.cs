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
    /// For stackable items, this changes the number of items in the stack.
    /// </summary>
    public class UpdateStackSizeS2C : Message
    {
        /// <summary>
        /// Sequence number for this message
        /// </summary>
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        /// <summary>
        /// Item getting it's stack adjusted.
        /// </summary>
        [MessageProperty]
        public uint ItemID { get; set; }        
        
        /// <summary>
        /// New number of items in the stack.
        /// </summary>
        [MessageProperty]
        public uint Amount { get; set; }        
        
        /// <summary>
        /// New value for the item.
        /// </summary>
        [MessageProperty]
        public uint NewValue { get; set; }        
        


        public UpdateStackSizeS2C() : base((MessageType)0x0197, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateStackSizeS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            ItemID = reader.ReadUInt32();
            Amount = reader.ReadUInt32();
            NewValue = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write(ItemID);
            writer.Write(Amount);
            writer.Write(NewValue);

        }


    }
}

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
    /// Splits an item to a wield location.
    /// </summary>
    public class StackableSplitToWieldC2S : OrderedMessage
    {
        /// <summary>
        /// ID of object being split
        /// </summary>
        [MessageProperty]
        public uint StackID { get; set; }        
        
        /// <summary>
        /// Equip location to place the stack
        /// </summary>
        [MessageProperty]
        public EquipMask Loc { get; set; }        
        
        /// <summary>
        /// Amount of stack being split
        /// </summary>
        [MessageProperty]
        public int Amount { get; set; }        
        


        public StackableSplitToWieldC2S() : base((MessageType)0x019B, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public StackableSplitToWieldC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            StackID = reader.ReadUInt32();
            Loc = (EquipMask)reader.ReadUInt32();
            Amount = reader.ReadInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(StackID);
            writer.Write((uint)Loc);
            writer.Write(Amount);

        }


    }
}

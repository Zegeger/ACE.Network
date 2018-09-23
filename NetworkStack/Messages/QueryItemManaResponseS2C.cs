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
    /// Update an item's mana bar.
    /// </summary>
    public class QueryItemManaResponseS2C : OrderedMessage
    {
        /// <summary>
        /// the object ID of the item
        /// </summary>
        [MessageProperty]
        public uint TargetID { get; set; }        
        
        /// <summary>
        /// the amount of mana remaining, scaled from 0.0 (none) to 1.0 (full)
        /// </summary>
        [MessageProperty]
        public float Mana { get; set; }        
        
        /// <summary>
        /// show mana bar: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public bool Success { get; set; }        
        


        public QueryItemManaResponseS2C() : base((MessageType)0x0264, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public QueryItemManaResponseS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            TargetID = reader.ReadUInt32();
            Mana = reader.ReadSingle();
            Success = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(TargetID);
            writer.Write(Mana);
            writer.WriteBool32(Success);

        }


    }
}

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
    /// Gets and weilds an item.
    /// </summary>
    public class GetAndWieldItemC2S : OrderedMessage
    {
        /// <summary>
        /// The item being equipped
        /// </summary>
        [MessageProperty]
        public uint Item { get; set; }        
        
        /// <summary>
        /// The position in the container where the item is being placed
        /// </summary>
        [MessageProperty]
        public EquipMask Slot { get; set; }        
        


        public GetAndWieldItemC2S() : base((MessageType)0x001A, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public GetAndWieldItemC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Item = reader.ReadUInt32();
            Slot = (EquipMask)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Item);
            writer.Write((uint)Slot);

        }


    }
}

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
    /// Sell to a vendor
    /// </summary>
    public class SellC2S : OrderedMessage
    {
        /// <summary>
        /// ID of vendor being sold to
        /// </summary>
        [MessageProperty]
        public uint VendorID { get; set; }        
        
        /// <summary>
        /// Items being sold to the vendor
        /// </summary>
        [MessageProperty]
        public PackableList<ItemProfile> Items { get; } = new PackableList<ItemProfile>(ReadItems, WriteItems);
        


        public SellC2S() : base((MessageType)0x0060, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SellC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            VendorID = reader.ReadUInt32();
            Items.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(VendorID);
            Items.Pack(writer);

        }

        static ItemProfile ReadItems(BinaryReader reader)
        {
            var item = new ItemProfile();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteItems(BinaryWriter writer, ItemProfile item)
        {
            item.Pack(writer);
        }
        

    }
}

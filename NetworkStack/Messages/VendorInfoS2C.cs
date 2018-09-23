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
    /// Open the buy/sell panel for a merchant.
    /// </summary>
    public class VendorInfoS2C : OrderedMessage
    {
        /// <summary>
        /// the object ID of the merchant
        /// </summary>
        [MessageProperty]
        public uint MerchantID { get; set; }        
        
        /// <summary>
        /// the object ID of the merchant
        /// </summary>
        [MessageProperty]
        public VendorProfile VendorProfile { get; } = new VendorProfile();
        
        /// <summary>
        /// Items available from the vendor
        /// </summary>
        [MessageProperty]
        public PackableList<ItemProfile> Items { get; } = new PackableList<ItemProfile>(ReadItems, WriteItems);
        


        public VendorInfoS2C() : base((MessageType)0x0062, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public VendorInfoS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            MerchantID = reader.ReadUInt32();
            VendorProfile.Unpack(reader);
            Items.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(MerchantID);
            VendorProfile.Pack(writer);
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

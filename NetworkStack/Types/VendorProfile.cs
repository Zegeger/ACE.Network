////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;

namespace ACE.Network.Types
{
    public class VendorProfile : IPackable
    {
        /// <summary>
        /// the categories of items the merchant will buy
        /// </summary>
        [MessageProperty]
        public ObjectType ItemTypes { get; set; }        
        
        /// <summary>
        /// the lowest value of an item the merchant will buy
        /// </summary>
        [MessageProperty]
        public uint MinValue { get; set; }        
        
        /// <summary>
        /// the highest value of an item the merchant will buy
        /// </summary>
        [MessageProperty]
        public uint MaxValue { get; set; }        
        
        [MessageProperty]
        public uint Magic { get; set; }        
        
        /// <summary>
        /// the merchant's buy rate
        /// </summary>
        [MessageProperty]
        public float BuyPrice { get; set; }        
        
        /// <summary>
        /// the merchant's sell rate
        /// </summary>
        [MessageProperty]
        public float SellPrice { get; set; }        
        
        /// <summary>
        /// wcid of currency
        /// </summary>
        [MessageProperty]
        public uint TradeID { get; set; }        
        
        /// <summary>
        /// amount of currency player has
        /// </summary>
        [MessageProperty]
        public uint TradeNum { get; set; }        
        
        /// <summary>
        /// name of currency
        /// </summary>
        [MessageProperty]
        public string TradeName { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            ItemTypes = (ObjectType)reader.ReadUInt32();
            MinValue = reader.ReadUInt32();
            MaxValue = reader.ReadUInt32();
            Magic = reader.ReadUInt32();
            BuyPrice = reader.ReadSingle();
            SellPrice = reader.ReadSingle();
            TradeID = reader.ReadUInt32();
            TradeNum = reader.ReadUInt32();
            TradeName = reader.ReadString16L();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)ItemTypes);
            writer.Write(MinValue);
            writer.Write(MaxValue);
            writer.Write(Magic);
            writer.Write(BuyPrice);
            writer.Write(SellPrice);
            writer.Write(TradeID);
            writer.Write(TradeNum);
            writer.WriteString16L(TradeName);

        }


    }
}

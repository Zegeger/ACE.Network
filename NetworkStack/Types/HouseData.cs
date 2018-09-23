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
    /// <summary>
    /// Set of information related to owning a housing
    /// </summary>
    public class HouseData : IPackable
    {
        /// <summary>
        /// when the house was purchased (Unix timestamp)
        /// </summary>
        [MessageProperty]
        public uint BuyTime { get; set; }        
        
        /// <summary>
        /// when the current maintenance period began (Unix timestamp)
        /// </summary>
        [MessageProperty]
        public uint RentTime { get; set; }        
        
        /// <summary>
        /// the type of house (1=cottage, 2=villa, 3=mansion, 4=apartment)
        /// </summary>
        [MessageProperty]
        public HouseType Type { get; set; }        
        
        /// <summary>
        /// indicates maintenance is free this period, I assume admin controlled
        /// </summary>
        [MessageProperty]
        public bool MaintenanceFree { get; set; }        
        
        [MessageProperty]
        public PackableList<HousePayment> Buy { get; } = new PackableList<HousePayment>(ReadBuy, WriteBuy);
        
        [MessageProperty]
        public PackableList<HousePayment> Rent { get; } = new PackableList<HousePayment>(ReadRent, WriteRent);
        
        /// <summary>
        /// house position
        /// </summary>
        [MessageProperty]
        public Position Position { get; } = new Position();
        


        public void Unpack(BinaryReader reader)
        {
            BuyTime = reader.ReadUInt32();
            RentTime = reader.ReadUInt32();
            Type = (HouseType)reader.ReadUInt32();
            MaintenanceFree = reader.ReadBool32();
            Buy.Unpack(reader);
            Rent.Unpack(reader);
            Position.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(BuyTime);
            writer.Write(RentTime);
            writer.Write((uint)Type);
            writer.WriteBool32(MaintenanceFree);
            Buy.Pack(writer);
            Rent.Pack(writer);
            Position.Pack(writer);

        }

        static HousePayment ReadBuy(BinaryReader reader)
        {
            var item = new HousePayment();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteBuy(BinaryWriter writer, HousePayment item)
        {
            item.Pack(writer);
        }
        
        static HousePayment ReadRent(BinaryReader reader)
        {
            var item = new HousePayment();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteRent(BinaryWriter writer, HousePayment item)
        {
            item.Pack(writer);
        }
        

    }
}

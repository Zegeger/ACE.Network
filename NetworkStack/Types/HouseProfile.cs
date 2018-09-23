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
    /// Set of information related to purchasing a housing
    /// </summary>
    public class HouseProfile : IPackable
    {
        /// <summary>
        /// the number associated with this dwelling
        /// </summary>
        [MessageProperty]
        public uint DwellingID { get; set; }        
        
        /// <summary>
        /// the object ID of the the current owner
        /// </summary>
        [MessageProperty]
        public uint OwnerID { get; set; }        
        
        [MessageProperty]
        public uint Bitmask { get; set; }        
        
        /// <summary>
        /// the level requirement to purchase this dwelling (-1 if no requirement)
        /// </summary>
        [MessageProperty]
        public int MinLevel { get; set; }        
        
        [MessageProperty]
        public int MaxLevel { get; set; }        
        
        /// <summary>
        /// the rank requirement to purchase this dwelling (-1 if no requirement)
        /// </summary>
        [MessageProperty]
        public int MinAllegRank { get; set; }        
        
        [MessageProperty]
        public int MaxAllegRank { get; set; }        
        
        [MessageProperty]
        public bool MaintenanceFree { get; set; }        
        
        /// <summary>
        /// the type of dwelling (1=cottage, 2=villa, 3=mansion, 4=apartment)
        /// </summary>
        [MessageProperty]
        public HouseType Type { get; set; }        
        
        /// <summary>
        /// the name of the current owner
        /// </summary>
        [MessageProperty]
        public string OwnerName { get; set; }        
        
        [MessageProperty]
        public PackableList<HousePayment> Buy { get; } = new PackableList<HousePayment>(ReadBuy, WriteBuy);
        
        [MessageProperty]
        public PackableList<HousePayment> Rent { get; } = new PackableList<HousePayment>(ReadRent, WriteRent);
        


        public void Unpack(BinaryReader reader)
        {
            DwellingID = reader.ReadUInt32();
            OwnerID = reader.ReadUInt32();
            Bitmask = reader.ReadUInt32();
            MinLevel = reader.ReadInt32();
            MaxLevel = reader.ReadInt32();
            MinAllegRank = reader.ReadInt32();
            MaxAllegRank = reader.ReadInt32();
            MaintenanceFree = reader.ReadBool32();
            Type = (HouseType)reader.ReadUInt32();
            OwnerName = reader.ReadString16L();
            Buy.Unpack(reader);
            Rent.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(DwellingID);
            writer.Write(OwnerID);
            writer.Write(Bitmask);
            writer.Write(MinLevel);
            writer.Write(MaxLevel);
            writer.Write(MinAllegRank);
            writer.Write(MaxAllegRank);
            writer.WriteBool32(MaintenanceFree);
            writer.Write((uint)Type);
            writer.WriteString16L(OwnerName);
            Buy.Pack(writer);
            Rent.Pack(writer);

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

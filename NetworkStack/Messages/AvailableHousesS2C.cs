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
    /// Display a list of available dwellings in the chat window.
    /// </summary>
    public class AvailableHousesS2C : OrderedMessage
    {
        /// <summary>
        /// The type of house (1=cottage, 2=villa, 3=mansion, 4=apartment)
        /// </summary>
        [MessageProperty]
        public HouseType HouseType { get; set; }        
        
        /// <summary>
        /// Landcell location of the houses
        /// </summary>
        [MessageProperty]
        public PackableList<uint> Houses { get; } = new PackableList<uint>(ReadHouses, WriteHouses);
        
        /// <summary>
        /// The total number of houses of this type available
        /// </summary>
        [MessageProperty]
        public int NumHouses { get; set; }        
        


        public AvailableHousesS2C() : base((MessageType)0x0271, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public AvailableHousesS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            HouseType = (HouseType)reader.ReadUInt32();
            Houses.Unpack(reader);
            NumHouses = reader.ReadInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)HouseType);
            Houses.Pack(writer);
            writer.Write(NumHouses);

        }

        static uint ReadHouses(BinaryReader reader)
        {
            var item = reader.ReadUInt32();
            return item;
        }
        
        static void WriteHouses(BinaryWriter writer, uint item)
        {
            writer.Write(item);
        }
        

    }
}

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
    /// Buy a house
    /// </summary>
    public class BuyHouseC2S : OrderedMessage
    {
        [MessageProperty]
        public uint Slumlord { get; set; }        
        
        /// <summary>
        /// items being used to buy the house
        /// </summary>
        [MessageProperty]
        public PackableList<uint> Items { get; } = new PackableList<uint>(ReadItems, WriteItems);
        


        public BuyHouseC2S() : base((MessageType)0x021C, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public BuyHouseC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Slumlord = reader.ReadUInt32();
            Items.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Slumlord);
            Items.Pack(writer);

        }

        static uint ReadItems(BinaryReader reader)
        {
            var item = reader.ReadUInt32();
            return item;
        }
        
        static void WriteItems(BinaryWriter writer, uint item)
        {
            writer.Write(item);
        }
        

    }
}

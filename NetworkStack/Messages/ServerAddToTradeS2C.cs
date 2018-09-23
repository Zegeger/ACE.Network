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
    /// AddToTrade: Item was added to the trade window
    /// </summary>
    public class ServerAddToTradeS2C : OrderedMessage
    {
        /// <summary>
        /// The item being added to trade window
        /// </summary>
        [MessageProperty]
        public uint ItemID { get; set; }        
        
        /// <summary>
        /// Side of the trade window object was added
        /// </summary>
        [MessageProperty]
        public TradeSide Side { get; set; }        
        
        /// <summary>
        /// Slot the item is going into
        /// </summary>
        [MessageProperty]
        public uint Position { get; set; }        
        


        public ServerAddToTradeS2C() : base((MessageType)0x0200, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ServerAddToTradeS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ItemID = reader.ReadUInt32();
            Side = (TradeSide)reader.ReadUInt32();
            Position = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ItemID);
            writer.Write((uint)Side);
            writer.Write(Position);

        }


    }
}

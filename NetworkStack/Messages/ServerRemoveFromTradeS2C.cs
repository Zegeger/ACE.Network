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
    /// Removes an item from the trade window, not sure if this is used still?
    /// </summary>
    public class ServerRemoveFromTradeS2C : OrderedMessage
    {
        /// <summary>
        /// The item being removed from the trade window
        /// </summary>
        [MessageProperty]
        public uint ItemID { get; set; }        
        
        /// <summary>
        /// Side of the trade window object was removed
        /// </summary>
        [MessageProperty]
        public TradeSide Side { get; set; }        
        


        public ServerRemoveFromTradeS2C() : base((MessageType)0x0201, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ServerRemoveFromTradeS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ItemID = reader.ReadUInt32();
            Side = (TradeSide)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ItemID);
            writer.Write((uint)Side);

        }


    }
}

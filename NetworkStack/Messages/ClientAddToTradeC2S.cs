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
    /// Adds an object to the trade.
    /// </summary>
    public class ClientAddToTradeC2S : OrderedMessage
    {
        /// <summary>
        /// ID of object to add to the trade
        /// </summary>
        [MessageProperty]
        public uint Item { get; set; }        
        
        /// <summary>
        /// Slot in trade window to add the object
        /// </summary>
        [MessageProperty]
        public uint Loc { get; set; }        
        


        public ClientAddToTradeC2S() : base((MessageType)0x01F8, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ClientAddToTradeC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Item = reader.ReadUInt32();
            Loc = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Item);
            writer.Write(Loc);

        }


    }
}

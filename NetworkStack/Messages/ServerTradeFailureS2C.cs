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
    /// TradeFailure: Failure to add a trade item
    /// </summary>
    public class ServerTradeFailureS2C : OrderedMessage
    {
        /// <summary>
        /// Item that could not be added to trade window
        /// </summary>
        [MessageProperty]
        public uint ItemID { get; set; }        
        
        /// <summary>
        /// The numeric reason it couldn't be traded. Client does not appear to use this.
        /// </summary>
        [MessageProperty]
        public uint Reason { get; set; }        
        


        public ServerTradeFailureS2C() : base((MessageType)0x0207, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ServerTradeFailureS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ItemID = reader.ReadUInt32();
            Reason = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ItemID);
            writer.Write(Reason);

        }


    }
}

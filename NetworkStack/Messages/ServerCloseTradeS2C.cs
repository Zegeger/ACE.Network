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
    /// CloseTrade: End trading
    /// </summary>
    public class ServerCloseTradeS2C : OrderedMessage
    {
        /// <summary>
        /// Reason trade was cancelled
        /// </summary>
        [MessageProperty]
        public EndTradeReason Reason { get; set; }        
        


        public ServerCloseTradeS2C() : base((MessageType)0x01FF, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ServerCloseTradeS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Reason = (EndTradeReason)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Reason);

        }


    }
}

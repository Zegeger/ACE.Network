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
    /// Starts trading with another player.
    /// </summary>
    public class OpenTradeNegotiationsC2S : OrderedMessage
    {
        /// <summary>
        /// ID of player to trade with
        /// </summary>
        [MessageProperty]
        public uint Other { get; set; }        
        


        public OpenTradeNegotiationsC2S() : base((MessageType)0x01F6, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public OpenTradeNegotiationsC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Other = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Other);

        }


    }
}

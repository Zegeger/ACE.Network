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
    /// Accepts a trade.
    /// </summary>
    public class ClientAcceptTradeC2S : OrderedMessage
    {
        /// <summary>
        /// The contents of the trade
        /// </summary>
        [MessageProperty]
        public Trade Stuff { get; } = new Trade();
        


        public ClientAcceptTradeC2S() : base((MessageType)0x01FA, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ClientAcceptTradeC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Stuff.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Stuff.Pack(writer);

        }


    }
}

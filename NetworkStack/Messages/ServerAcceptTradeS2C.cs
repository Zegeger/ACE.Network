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
    /// AcceptTrade: The trade was accepted
    /// </summary>
    public class ServerAcceptTradeS2C : OrderedMessage
    {
        /// <summary>
        /// Person who accepted the trade
        /// </summary>
        [MessageProperty]
        public uint SourceID { get; set; }        
        


        public ServerAcceptTradeS2C() : base((MessageType)0x0202, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ServerAcceptTradeS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            SourceID = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(SourceID);

        }


    }
}

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
    /// OpenTrade: Open trade window
    /// </summary>
    public class ServerOpenTradeS2C : OrderedMessage
    {
        /// <summary>
        /// Person opening the trade
        /// </summary>
        [MessageProperty]
        public uint SourceID { get; set; }        
        


        public ServerOpenTradeS2C() : base((MessageType)0x01FE, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ServerOpenTradeS2C(BinaryReader reader) : this()
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

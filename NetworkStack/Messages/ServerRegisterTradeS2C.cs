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
    /// RegisterTrade: Send to begin a trade and display the trade window
    /// </summary>
    public class ServerRegisterTradeS2C : OrderedMessage
    {
        /// <summary>
        /// Person initiating the trade
        /// </summary>
        [MessageProperty]
        public uint Initiator { get; set; }        
        
        /// <summary>
        /// Person receiving the trade
        /// </summary>
        [MessageProperty]
        public uint Partner { get; set; }        
        
        /// <summary>
        /// Some kind of stamp
        /// </summary>
        [MessageProperty]
        public long Stamp { get; set; }        
        


        public ServerRegisterTradeS2C() : base((MessageType)0x01FD, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ServerRegisterTradeS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Initiator = reader.ReadUInt32();
            Partner = reader.ReadUInt32();
            Stamp = reader.ReadInt64();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Initiator);
            writer.Write(Partner);
            writer.Write(Stamp);

        }


    }
}

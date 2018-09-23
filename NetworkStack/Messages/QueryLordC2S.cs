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
    /// Gets SlumLord info, sent after getting a failed house transaction
    /// </summary>
    public class QueryLordC2S : OrderedMessage
    {
        /// <summary>
        /// SlumLord ID to request info for
        /// </summary>
        [MessageProperty]
        public uint Lord { get; set; }        
        


        public QueryLordC2S() : base((MessageType)0x0258, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public QueryLordC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Lord = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Lord);

        }


    }
}

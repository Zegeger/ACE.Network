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
    /// DDD request for data
    /// </summary>
    public class RequestDataMessageC2S : Message
    {
        /// <summary>
        /// the resource type
        /// </summary>
        [MessageProperty]
        public uint ResourceType { get; set; }        
        
        /// <summary>
        /// the resource ID number
        /// </summary>
        [MessageProperty]
        public uint ResourceId { get; set; }        
        


        public RequestDataMessageC2S() : base((MessageType)0xF7E3, MessageDirection.ClientToServer, (Queues)0x00000005)
        { }

        public RequestDataMessageC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ResourceType = reader.ReadUInt32();
            ResourceId = reader.ReadUIntCompressed16();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ResourceType);
            writer.WriteUIntCompressed16(ResourceId);

        }


    }
}

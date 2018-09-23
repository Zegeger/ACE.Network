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
    /// Drop an item.
    /// </summary>
    public class DropItemC2S : OrderedMessage
    {
        /// <summary>
        /// The item being dropped
        /// </summary>
        [MessageProperty]
        public uint Item { get; set; }        
        


        public DropItemC2S() : base((MessageType)0x001B, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public DropItemC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Item = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Item);

        }


    }
}

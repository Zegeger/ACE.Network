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
    /// Store an item in a container.
    /// </summary>
    public class PutItemInContainerC2S : OrderedMessage
    {
        /// <summary>
        /// The item being stored
        /// </summary>
        [MessageProperty]
        public uint Item { get; set; }        
        
        /// <summary>
        /// The container the item is being stored in
        /// </summary>
        [MessageProperty]
        public uint Container { get; set; }        
        
        /// <summary>
        /// The position in the container where the item is being placed
        /// </summary>
        [MessageProperty]
        public uint Loc { get; set; }        
        


        public PutItemInContainerC2S() : base((MessageType)0x0019, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public PutItemInContainerC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Item = reader.ReadUInt32();
            Container = reader.ReadUInt32();
            Loc = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Item);
            writer.Write(Container);
            writer.Write(Loc);

        }


    }
}

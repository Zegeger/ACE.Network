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
    /// Set Pack Contents
    /// </summary>
    public class OnViewContentsS2C : OrderedMessage
    {
        /// <summary>
        /// The pack we are setting the contents of. This pack objects and the contained objects may be created before or after the message.
        /// </summary>
        [MessageProperty]
        public uint ContainerID { get; set; }        
        
        [MessageProperty]
        public PackableList<ContentProfile> Items { get; } = new PackableList<ContentProfile>(ReadItems, WriteItems);
        


        public OnViewContentsS2C() : base((MessageType)0x0196, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public OnViewContentsS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ContainerID = reader.ReadUInt32();
            Items.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ContainerID);
            Items.Pack(writer);

        }

        static ContentProfile ReadItems(BinaryReader reader)
        {
            var item = new ContentProfile();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteItems(BinaryWriter writer, ContentProfile item)
        {
            item.Pack(writer);
        }
        

    }
}

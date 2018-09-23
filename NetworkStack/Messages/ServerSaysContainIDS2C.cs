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
    public class ServerSaysContainIDS2C : OrderedMessage
    {
        /// <summary>
        /// the object ID of the item being stored
        /// </summary>
        [MessageProperty]
        public uint ItemID { get; set; }        
        
        /// <summary>
        /// the object ID of the container the item is being stored in
        /// </summary>
        [MessageProperty]
        public uint ContainerID { get; set; }        
        
        /// <summary>
        /// the item slot within the container where the item is being placed (0-based)
        /// </summary>
        [MessageProperty]
        public uint Slot { get; set; }        
        
        /// <summary>
        /// the type of item being stored (pack, foci or regular item)
        /// </summary>
        [MessageProperty]
        public ContainerProperties ContainerProperties { get; set; }        
        


        public ServerSaysContainIDS2C() : base((MessageType)0x0022, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ServerSaysContainIDS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ItemID = reader.ReadUInt32();
            ContainerID = reader.ReadUInt32();
            Slot = reader.ReadUInt32();
            ContainerProperties = (ContainerProperties)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ItemID);
            writer.Write(ContainerID);
            writer.Write(Slot);
            writer.Write((uint)ContainerProperties);

        }


    }
}

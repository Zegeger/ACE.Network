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
    /// ServerSaysMoveItem: Removes an item from inventory (when you place it on the ground or give it away)
    /// </summary>
    public class ServerSaysMoveItemS2C : OrderedMessage
    {
        /// <summary>
        /// The item leaving your inventory.
        /// </summary>
        [MessageProperty]
        public uint Item { get; set; }        
        


        public ServerSaysMoveItemS2C() : base((MessageType)0x019A, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ServerSaysMoveItemS2C(BinaryReader reader) : this()
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

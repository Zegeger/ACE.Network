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
    /// Queries an item's mana
    /// </summary>
    public class QueryItemManaC2S : OrderedMessage
    {
        /// <summary>
        /// ID of object whos mana is being queried
        /// </summary>
        [MessageProperty]
        public uint Target { get; set; }        
        


        public QueryItemManaC2S() : base((MessageType)0x0263, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public QueryItemManaC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Target = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Target);

        }


    }
}

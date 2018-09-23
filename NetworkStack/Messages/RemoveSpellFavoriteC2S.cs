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
    /// Remove a spell from a spell bar.
    /// </summary>
    public class RemoveSpellFavoriteC2S : OrderedMessage
    {
        /// <summary>
        /// The spell's ID
        /// </summary>
        [MessageProperty]
        public LayeredSpellID Spid { get; } = new LayeredSpellID();
        
        /// <summary>
        /// The spell bar number
        /// </summary>
        [MessageProperty]
        public uint List { get; set; }        
        


        public RemoveSpellFavoriteC2S() : base((MessageType)0x01E4, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public RemoveSpellFavoriteC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Spid.Unpack(reader);
            List = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            Spid.Pack(writer);
            writer.Write(List);

        }


    }
}

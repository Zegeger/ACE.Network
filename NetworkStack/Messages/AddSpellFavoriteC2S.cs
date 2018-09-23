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
    /// Add a spell to a spell bar.
    /// </summary>
    public class AddSpellFavoriteC2S : OrderedMessage
    {
        /// <summary>
        /// The spell's ID
        /// </summary>
        [MessageProperty]
        public LayeredSpellID Spid { get; } = new LayeredSpellID();
        
        /// <summary>
        /// Position on the spell bar where the spell is to be added
        /// </summary>
        [MessageProperty]
        public uint Index { get; set; }        
        
        /// <summary>
        /// The spell bar number
        /// </summary>
        [MessageProperty]
        public uint List { get; set; }        
        


        public AddSpellFavoriteC2S() : base((MessageType)0x01E3, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public AddSpellFavoriteC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Spid.Unpack(reader);
            Index = reader.ReadUInt32();
            List = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            Spid.Pack(writer);
            writer.Write(Index);
            writer.Write(List);

        }


    }
}

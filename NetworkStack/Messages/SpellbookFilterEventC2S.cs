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
    /// Changes the spell book filter
    /// </summary>
    public class SpellbookFilterEventC2S : OrderedMessage
    {
        /// <summary>
        /// Mask containing the different filters applied to the spellbook
        /// </summary>
        [MessageProperty]
        public SpellBookFilterOptions Options { get; set; }        
        


        public SpellbookFilterEventC2S() : base((MessageType)0x0286, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SpellbookFilterEventC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Options = (SpellBookFilterOptions)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Options);

        }


    }
}

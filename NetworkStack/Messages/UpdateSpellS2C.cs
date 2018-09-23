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
    /// Add a spell to your spellbook.
    /// </summary>
    public class UpdateSpellS2C : OrderedMessage
    {
        /// <summary>
        /// the spell ID of the new spell
        /// </summary>
        [MessageProperty]
        public LayeredSpellID Spell { get; } = new LayeredSpellID();
        


        public UpdateSpellS2C() : base((MessageType)0x02C1, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateSpellS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Spell.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Spell.Pack(writer);

        }


    }
}

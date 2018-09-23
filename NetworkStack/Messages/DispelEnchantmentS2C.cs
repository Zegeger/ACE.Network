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
    /// Silently remove An enchantment from your character.
    /// </summary>
    public class DispelEnchantmentS2C : OrderedMessage
    {
        /// <summary>
        /// the spell ID of the enchantment to be removed
        /// </summary>
        [MessageProperty]
        public LayeredSpellID Spell { get; } = new LayeredSpellID();
        


        public DispelEnchantmentS2C() : base((MessageType)0x02C7, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public DispelEnchantmentS2C(BinaryReader reader) : this()
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

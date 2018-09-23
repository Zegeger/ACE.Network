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
    /// Silently remove multiple enchantments from your character (no message in the chat window).
    /// </summary>
    public class DispelMultipleEnchantmentsS2C : OrderedMessage
    {
        /// <summary>
        /// List of enchantments getting removed
        /// </summary>
        [MessageProperty]
        public PackableList<LayeredSpellID> Enchantments { get; } = new PackableList<LayeredSpellID>(ReadEnchantments, WriteEnchantments);
        


        public DispelMultipleEnchantmentsS2C() : base((MessageType)0x02C8, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public DispelMultipleEnchantmentsS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Enchantments.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Enchantments.Pack(writer);

        }

        static LayeredSpellID ReadEnchantments(BinaryReader reader)
        {
            var item = new LayeredSpellID();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteEnchantments(BinaryWriter writer, LayeredSpellID item)
        {
            item.Pack(writer);
        }
        

    }
}

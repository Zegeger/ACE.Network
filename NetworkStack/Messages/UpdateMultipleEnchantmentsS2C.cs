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
    /// Update multiple enchantments from your character.
    /// </summary>
    public class UpdateMultipleEnchantmentsS2C : OrderedMessage
    {
        /// <summary>
        /// List of enchantments getting updated
        /// </summary>
        [MessageProperty]
        public PackableList<Enchantment> Enchantments { get; } = new PackableList<Enchantment>(ReadEnchantments, WriteEnchantments);
        


        public UpdateMultipleEnchantmentsS2C() : base((MessageType)0x02C4, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateMultipleEnchantmentsS2C(BinaryReader reader) : this()
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

        static Enchantment ReadEnchantments(BinaryReader reader)
        {
            var item = new Enchantment();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteEnchantments(BinaryWriter writer, Enchantment item)
        {
            item.Pack(writer);
        }
        

    }
}

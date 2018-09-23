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
    /// Apply an enchantment to your character.
    /// </summary>
    public class UpdateEnchantmentS2C : OrderedMessage
    {
        [MessageProperty]
        public Enchantment Enchantment { get; } = new Enchantment();
        


        public UpdateEnchantmentS2C() : base((MessageType)0x02C2, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateEnchantmentS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Enchantment.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Enchantment.Pack(writer);

        }


    }
}

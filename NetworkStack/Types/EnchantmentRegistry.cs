////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;

namespace ACE.Network.Types
{
    /// <summary>
    /// Contains information related to the spells in effect on the character
    /// </summary>
    public class EnchantmentRegistry : IPackable
    {
        /// <summary>
        /// Enchantment mask.
        /// </summary>
        [MessageProperty]
        public uint EnchantmentMask { get; set; }        
        
        /// <summary>
        /// Life spells active on the player
        /// </summary>
        [MessageProperty]
        public PackableList<Enchantment> LifeSpells { get; } = new PackableList<Enchantment>(ReadLifeSpells, WriteLifeSpells);
        
        /// <summary>
        /// Creature spells active on the player
        /// </summary>
        [MessageProperty]
        public PackableList<Enchantment> CreatureSpells { get; } = new PackableList<Enchantment>(ReadCreatureSpells, WriteCreatureSpells);
        
        /// <summary>
        /// Cooldown spells active on the player
        /// </summary>
        [MessageProperty]
        public PackableList<Enchantment> Cooldowns { get; } = new PackableList<Enchantment>(ReadCooldowns, WriteCooldowns);
        
        /// <summary>
        /// Vitae Penalty.
        /// </summary>
        [MessageProperty]
        public Enchantment Vitae { get; } = new Enchantment();
        


        public void Unpack(BinaryReader reader)
        {
            EnchantmentMask = reader.ReadUInt32();
            if((EnchantmentMask & 0x0001) != 0)
            {
                LifeSpells.Unpack(reader);
            }
            if((EnchantmentMask & 0x0002) != 0)
            {
                CreatureSpells.Unpack(reader);
            }
            if((EnchantmentMask & 0x0008) != 0)
            {
                Cooldowns.Unpack(reader);
            }
            if((EnchantmentMask & 0x0004) != 0)
            {
                Vitae.Unpack(reader);
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(EnchantmentMask);
            if((EnchantmentMask & 0x0001) != 0)
            {
                LifeSpells.Pack(writer);
            }
            if((EnchantmentMask & 0x0002) != 0)
            {
                CreatureSpells.Pack(writer);
            }
            if((EnchantmentMask & 0x0008) != 0)
            {
                Cooldowns.Pack(writer);
            }
            if((EnchantmentMask & 0x0004) != 0)
            {
                Vitae.Pack(writer);
            }

        }

        static Enchantment ReadLifeSpells(BinaryReader reader)
        {
            var item = new Enchantment();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteLifeSpells(BinaryWriter writer, Enchantment item)
        {
            item.Pack(writer);
        }
        
        static Enchantment ReadCreatureSpells(BinaryReader reader)
        {
            var item = new Enchantment();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteCreatureSpells(BinaryWriter writer, Enchantment item)
        {
            item.Pack(writer);
        }
        
        static Enchantment ReadCooldowns(BinaryReader reader)
        {
            var item = new Enchantment();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteCooldowns(BinaryWriter writer, Enchantment item)
        {
            item.Pack(writer);
        }
        

    }
}

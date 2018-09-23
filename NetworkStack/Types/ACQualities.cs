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
    /// The ACQualities structure contains character property lists.
    /// </summary>
    public class ACQualities : IPackable
    {
        /// <summary>
        /// Contains basic data types (int, float bool, etc.)
        /// </summary>
        [MessageProperty]
        public ACBaseQualities BaseQualities { get; } = new ACBaseQualities();
        
        /// <summary>
        /// determines which property vector types appear in the message
        /// </summary>
        [MessageProperty]
        public uint Flags { get; set; }        
        
        /// <summary>
        /// seems to indicate this object has health attribute
        /// </summary>
        [MessageProperty]
        public bool HasHealth { get; set; }        
        
        /// <summary>
        /// The character attributes
        /// </summary>
        [MessageProperty]
        public AttributeCache AttribCache { get; } = new AttributeCache();
        
        [MessageProperty]
        public PackableHashTable<SkillID,Skill> SkillTable { get; } = new PackableHashTable<SkillID,Skill>(ReadSkillTable, WriteSkillTable);
        
        [MessageProperty]
        public Body Body { get; } = new Body();
        
        /// <summary>
        /// Spells in the characters spellbook
        /// </summary>
        [MessageProperty]
        public SpellBook SpellBook { get; } = new SpellBook();
        
        /// <summary>
        /// The enchantments active on the character
        /// </summary>
        [MessageProperty]
        public EnchantmentRegistry EnchantmentRegistry { get; } = new EnchantmentRegistry();
        
        /// <summary>
        /// Some kind of event filter
        /// </summary>
        [MessageProperty]
        public EventFilter Filter { get; } = new EventFilter();
        
        [MessageProperty]
        public EmoteTable Table { get; } = new EmoteTable();
        
        [MessageProperty]
        public PackableList<CreationProfile> CreationProfile { get; } = new PackableList<CreationProfile>(ReadCreationProfile, WriteCreationProfile);
        
        [MessageProperty]
        public PageDataList PageDataList { get; } = new PageDataList();
        
        [MessageProperty]
        public GeneratorTable GeneratorTable { get; } = new GeneratorTable();
        
        [MessageProperty]
        public GeneratorRegistry GeneratorRegistry { get; } = new GeneratorRegistry();
        
        [MessageProperty]
        public GeneratorQueue GeneratorQueue { get; } = new GeneratorQueue();
        


        public void Unpack(BinaryReader reader)
        {
            BaseQualities.Unpack(reader);
            Flags = reader.ReadUInt32();
            HasHealth = reader.ReadBool32();
            if((Flags & 0x00000001) != 0)
            {
                AttribCache.Unpack(reader);
            }
            if((Flags & 0x00000002) != 0)
            {
                SkillTable.Unpack(reader);
            }
            if((Flags & 0x00000004) != 0)
            {
                Body.Unpack(reader);
            }
            if((Flags & 0x00000100) != 0)
            {
                SpellBook.Unpack(reader);
            }
            if((Flags & 0x00000200) != 0)
            {
                EnchantmentRegistry.Unpack(reader);
            }
            if((Flags & 0x00000008) != 0)
            {
                Filter.Unpack(reader);
            }
            if((Flags & 0x00000010) != 0)
            {
                Table.Unpack(reader);
            }
            if((Flags & 0x00000020) != 0)
            {
                CreationProfile.Unpack(reader);
            }
            if((Flags & 0x00000040) != 0)
            {
                PageDataList.Unpack(reader);
            }
            if((Flags & 0x00000080) != 0)
            {
                GeneratorTable.Unpack(reader);
            }
            if((Flags & 0x00000400) != 0)
            {
                GeneratorRegistry.Unpack(reader);
            }
            if((Flags & 0x00000800) != 0)
            {
                GeneratorQueue.Unpack(reader);
            }

        }

        public void Pack(BinaryWriter writer)
        {
            BaseQualities.Pack(writer);
            writer.Write(Flags);
            writer.WriteBool32(HasHealth);
            if((Flags & 0x00000001) != 0)
            {
                AttribCache.Pack(writer);
            }
            if((Flags & 0x00000002) != 0)
            {
                SkillTable.Pack(writer);
            }
            if((Flags & 0x00000004) != 0)
            {
                Body.Pack(writer);
            }
            if((Flags & 0x00000100) != 0)
            {
                SpellBook.Pack(writer);
            }
            if((Flags & 0x00000200) != 0)
            {
                EnchantmentRegistry.Pack(writer);
            }
            if((Flags & 0x00000008) != 0)
            {
                Filter.Pack(writer);
            }
            if((Flags & 0x00000010) != 0)
            {
                Table.Pack(writer);
            }
            if((Flags & 0x00000020) != 0)
            {
                CreationProfile.Pack(writer);
            }
            if((Flags & 0x00000040) != 0)
            {
                PageDataList.Pack(writer);
            }
            if((Flags & 0x00000080) != 0)
            {
                GeneratorTable.Pack(writer);
            }
            if((Flags & 0x00000400) != 0)
            {
                GeneratorRegistry.Pack(writer);
            }
            if((Flags & 0x00000800) != 0)
            {
                GeneratorQueue.Pack(writer);
            }

        }

        static KeyValuePair<SkillID, Skill> ReadSkillTable(BinaryReader reader)
        {
            var key = (SkillID)reader.ReadUInt32();
            var val = new Skill();
            val.Unpack(reader);
            return new KeyValuePair<SkillID, Skill>(key, val);
        }
        
        static void WriteSkillTable(BinaryWriter writer, KeyValuePair<SkillID, Skill> pair)
        {
            writer.Write((uint)pair.Key);
            pair.Value.Pack(writer);
        }
        
        static CreationProfile ReadCreationProfile(BinaryReader reader)
        {
            var item = new CreationProfile();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteCreationProfile(BinaryWriter writer, CreationProfile item)
        {
            item.Pack(writer);
        }
        

    }
}

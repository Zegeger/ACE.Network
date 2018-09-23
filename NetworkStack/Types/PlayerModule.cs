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
    /// The PlayerModule structure contains character options.
    /// </summary>
    public class PlayerModule : IPackable
    {
        [MessageProperty]
        public uint Flags { get; set; }        
        
        /// <summary>
        /// The options in the Character tab (F11 by default)
        /// </summary>
        [MessageProperty]
        public CharacterOptions1 Options { get; set; }        
        
        /// <summary>
        /// Shortcut items.
        /// </summary>
        [MessageProperty]
        public ShortCutManager ShortCutManager { get; } = new ShortCutManager();
        
        /// <summary>
        /// Spells in the spell tab
        /// </summary>
        [MessageProperty]
        public SpellTab Tab1 { get; } = new SpellTab();
        
        /// <summary>
        /// Spells in the spell tab
        /// </summary>
        [MessageProperty]
        public SpellTab Tab2 { get; } = new SpellTab();
        
        /// <summary>
        /// Spells in the spell tab
        /// </summary>
        [MessageProperty]
        public SpellTab Tab3 { get; } = new SpellTab();
        
        /// <summary>
        /// Spells in the spell tab
        /// </summary>
        [MessageProperty]
        public SpellTab Tab4 { get; } = new SpellTab();
        
        /// <summary>
        /// Spells in the spell tab
        /// </summary>
        [MessageProperty]
        public SpellTab Tab5 { get; } = new SpellTab();
        
        /// <summary>
        /// Spells in the spell tab
        /// </summary>
        [MessageProperty]
        public SpellTab Tab6 { get; } = new SpellTab();
        
        /// <summary>
        /// Spells in the spell tab
        /// </summary>
        [MessageProperty]
        public SpellTab Tab7 { get; } = new SpellTab();
        
        /// <summary>
        /// Spells in the spell tab
        /// </summary>
        [MessageProperty]
        public SpellTab Tab8 { get; } = new SpellTab();
        
        /// <summary>
        /// Lists component type and the desired level
        /// </summary>
        [MessageProperty]
        public PackableHashTable<uint,uint> DesiredComps { get; } = new PackableHashTable<uint,uint>(ReadDesiredComps, WriteDesiredComps);
        
        /// <summary>
        /// Defaults to 0x3FFF if not present
        /// </summary>
        [MessageProperty]
        public SpellBookFilterOptions SpellFilters { get; set; }        
        
        /// <summary>
        /// Character options second batch, defaults to 9733888 if not present
        /// </summary>
        [MessageProperty]
        public CharacterOptions2 Options2 { get; set; }        
        
        [MessageProperty]
        public string TimestampFormat { get; set; }        
        
        [MessageProperty]
        public GenericQualitiesData GenericQualities { get; } = new GenericQualitiesData();
        
        [MessageProperty]
        public uint VersionRow { get; set; }        
        
        [MessageProperty]
        public FloatingWindowSettings Properties { get; } = new FloatingWindowSettings();
        


        public void Unpack(BinaryReader reader)
        {
            Flags = reader.ReadUInt32();
            Options = (CharacterOptions1)reader.ReadUInt32();
            if((Flags & 0x00000001) != 0)
            {
                ShortCutManager.Unpack(reader);
            }
            Tab1.Unpack(reader);
            if((Flags & 0x00000004) != 0)
            {
                Tab2.Unpack(reader);
                Tab3.Unpack(reader);
                Tab4.Unpack(reader);
                Tab5.Unpack(reader);
            }
            if((Flags & 0x00000010) != 0)
            {
                Tab2.Unpack(reader);
                Tab3.Unpack(reader);
                Tab4.Unpack(reader);
                Tab5.Unpack(reader);
                Tab6.Unpack(reader);
                Tab7.Unpack(reader);
            }
            if((Flags & 0x00000400) != 0)
            {
                Tab2.Unpack(reader);
                Tab3.Unpack(reader);
                Tab4.Unpack(reader);
                Tab5.Unpack(reader);
                Tab6.Unpack(reader);
                Tab7.Unpack(reader);
                Tab8.Unpack(reader);
            }
            if((Flags & 0x00000008) != 0)
            {
                DesiredComps.Unpack(reader);
            }
            if((Flags & 0x00000020) != 0)
            {
                SpellFilters = (SpellBookFilterOptions)reader.ReadUInt32();
            }
            if((Flags & 0x00000040) != 0)
            {
                Options2 = (CharacterOptions2)reader.ReadUInt32();
            }
            if((Flags & 0x00000080) != 0)
            {
                TimestampFormat = reader.ReadString16L();
            }
            if((Flags & 0x00000100) != 0)
            {
                GenericQualities.Unpack(reader);
            }
            if((Flags & 0x00000200) != 0)
            {
                VersionRow = reader.ReadUInt32();
                Properties.Unpack(reader);
                reader.Align();
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Flags);
            writer.Write((uint)Options);
            if((Flags & 0x00000001) != 0)
            {
                ShortCutManager.Pack(writer);
            }
            Tab1.Pack(writer);
            if((Flags & 0x00000004) != 0)
            {
                Tab2.Pack(writer);
                Tab3.Pack(writer);
                Tab4.Pack(writer);
                Tab5.Pack(writer);
            }
            if((Flags & 0x00000010) != 0)
            {
                Tab2.Pack(writer);
                Tab3.Pack(writer);
                Tab4.Pack(writer);
                Tab5.Pack(writer);
                Tab6.Pack(writer);
                Tab7.Pack(writer);
            }
            if((Flags & 0x00000400) != 0)
            {
                Tab2.Pack(writer);
                Tab3.Pack(writer);
                Tab4.Pack(writer);
                Tab5.Pack(writer);
                Tab6.Pack(writer);
                Tab7.Pack(writer);
                Tab8.Pack(writer);
            }
            if((Flags & 0x00000008) != 0)
            {
                DesiredComps.Pack(writer);
            }
            if((Flags & 0x00000020) != 0)
            {
                writer.Write((uint)SpellFilters);
            }
            if((Flags & 0x00000040) != 0)
            {
                writer.Write((uint)Options2);
            }
            if((Flags & 0x00000080) != 0)
            {
                writer.WriteString16L(TimestampFormat);
            }
            if((Flags & 0x00000100) != 0)
            {
                GenericQualities.Pack(writer);
            }
            if((Flags & 0x00000200) != 0)
            {
                writer.Write(VersionRow);
                Properties.Pack(writer);
                writer.Align();
            }

        }

        static KeyValuePair<uint, uint> ReadDesiredComps(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = reader.ReadUInt32();
            return new KeyValuePair<uint, uint>(key, val);
        }
        
        static void WriteDesiredComps(BinaryWriter writer, KeyValuePair<uint, uint> pair)
        {
            writer.Write(pair.Key);
            writer.Write(pair.Value);
        }
        

    }
}

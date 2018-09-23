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
    /// The Enchantment structure describes an active enchantment.
    /// </summary>
    public class Enchantment : IPackable
    {
        /// <summary>
        /// the spell ID of the enchantment
        /// </summary>
        [MessageProperty]
        public LayeredSpellID Id { get; } = new LayeredSpellID();
        
        /// <summary>
        /// Value greater or equal to 1 means we read spellSetID
        /// </summary>
        [MessageProperty]
        public ushort HasSpellSetID { get; set; }        
        
        /// <summary>
        /// the family of related spells this enchantment belongs to
        /// </summary>
        [MessageProperty]
        public ushort SpellCategory { get; set; }        
        
        /// <summary>
        /// the difficulty of the spell
        /// </summary>
        [MessageProperty]
        public uint PowerLevel { get; set; }        
        
        /// <summary>
        /// the amount of time this enchantment has been active
        /// </summary>
        [MessageProperty]
        public double StartTime { get; set; }        
        
        /// <summary>
        /// the duration of the spell
        /// </summary>
        [MessageProperty]
        public double Duration { get; set; }        
        
        /// <summary>
        /// the object ID of the creature or item that cast this enchantment
        /// </summary>
        [MessageProperty]
        public uint Caster { get; set; }        
        
        /// <summary>
        /// unknown
        /// </summary>
        [MessageProperty]
        public float DegradeModifier { get; set; }        
        
        /// <summary>
        /// unknown
        /// </summary>
        [MessageProperty]
        public float DegradeLimit { get; set; }        
        
        /// <summary>
        /// the time when this enchantment was cast
        /// </summary>
        [MessageProperty]
        public double LastTimeDegraded { get; set; }        
        
        /// <summary>
        /// Stat modification information
        /// </summary>
        [MessageProperty]
        public StatMod Smod { get; } = new StatMod();
        
        /// <summary>
        /// Related to armor sets somehow?
        /// </summary>
        [MessageProperty]
        public uint SpellSetID { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Id.Unpack(reader);
            HasSpellSetID = reader.ReadUInt16();
            SpellCategory = reader.ReadUInt16();
            PowerLevel = reader.ReadUInt32();
            StartTime = reader.ReadDouble();
            Duration = reader.ReadDouble();
            Caster = reader.ReadUInt32();
            DegradeModifier = reader.ReadSingle();
            DegradeLimit = reader.ReadSingle();
            LastTimeDegraded = reader.ReadDouble();
            Smod.Unpack(reader);
            if(HasSpellSetID > 0)
            {
                SpellSetID = reader.ReadUInt32();
            }

        }

        public void Pack(BinaryWriter writer)
        {
            Id.Pack(writer);
            writer.Write(HasSpellSetID);
            writer.Write(SpellCategory);
            writer.Write(PowerLevel);
            writer.Write(StartTime);
            writer.Write(Duration);
            writer.Write(Caster);
            writer.Write(DegradeModifier);
            writer.Write(DegradeLimit);
            writer.Write(LastTimeDegraded);
            Smod.Pack(writer);
            if(HasSpellSetID > 0)
            {
                writer.Write(SpellSetID);
            }

        }


    }
}

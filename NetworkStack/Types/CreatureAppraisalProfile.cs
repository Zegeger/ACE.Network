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
    public class CreatureAppraisalProfile : IPackable
    {
        /// <summary>
        /// These Flags indication which members will be available for assess.
        /// </summary>
        [MessageProperty]
        public uint Flags { get; set; }        
        
        /// <summary>
        /// current health
        /// </summary>
        [MessageProperty]
        public uint Health { get; set; }        
        
        /// <summary>
        /// maximum health
        /// </summary>
        [MessageProperty]
        public uint HealthMax { get; set; }        
        
        /// <summary>
        /// strength
        /// </summary>
        [MessageProperty]
        public uint Strength { get; set; }        
        
        /// <summary>
        /// endurance
        /// </summary>
        [MessageProperty]
        public uint Endurance { get; set; }        
        
        /// <summary>
        /// quickness
        /// </summary>
        [MessageProperty]
        public uint Quickness { get; set; }        
        
        /// <summary>
        /// coordination
        /// </summary>
        [MessageProperty]
        public uint Coordination { get; set; }        
        
        /// <summary>
        /// focus
        /// </summary>
        [MessageProperty]
        public uint Focus { get; set; }        
        
        /// <summary>
        /// self
        /// </summary>
        [MessageProperty]
        public uint Self { get; set; }        
        
        /// <summary>
        /// current stamina
        /// </summary>
        [MessageProperty]
        public uint Stamina { get; set; }        
        
        /// <summary>
        /// current mana
        /// </summary>
        [MessageProperty]
        public uint Mana { get; set; }        
        
        /// <summary>
        /// maximum stamina
        /// </summary>
        [MessageProperty]
        public uint StaminaMax { get; set; }        
        
        /// <summary>
        /// maximum mana
        /// </summary>
        [MessageProperty]
        public uint ManaMax { get; set; }        
        
        /// <summary>
        /// highlight enable bitmask: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public AttributeMask AttrHighlight { get; set; }        
        
        /// <summary>
        /// highlight color bitmask: 0=red, 1=green
        /// </summary>
        [MessageProperty]
        public AttributeMask AttrColor { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Flags = reader.ReadUInt32();
            Health = reader.ReadUInt32();
            HealthMax = reader.ReadUInt32();
            if((Flags & 0x00000008) != 0)
            {
                Strength = reader.ReadUInt32();
                Endurance = reader.ReadUInt32();
                Quickness = reader.ReadUInt32();
                Coordination = reader.ReadUInt32();
                Focus = reader.ReadUInt32();
                Self = reader.ReadUInt32();
                Stamina = reader.ReadUInt32();
                Mana = reader.ReadUInt32();
                StaminaMax = reader.ReadUInt32();
                ManaMax = reader.ReadUInt32();
            }
            if((Flags & 0x00000001) != 0)
            {
                AttrHighlight = (AttributeMask)reader.ReadUInt16();
                AttrColor = (AttributeMask)reader.ReadUInt16();
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Flags);
            writer.Write(Health);
            writer.Write(HealthMax);
            if((Flags & 0x00000008) != 0)
            {
                writer.Write(Strength);
                writer.Write(Endurance);
                writer.Write(Quickness);
                writer.Write(Coordination);
                writer.Write(Focus);
                writer.Write(Self);
                writer.Write(Stamina);
                writer.Write(Mana);
                writer.Write(StaminaMax);
                writer.Write(ManaMax);
            }
            if((Flags & 0x00000001) != 0)
            {
                writer.Write((ushort)AttrHighlight);
                writer.Write((ushort)AttrColor);
            }

        }


    }
}

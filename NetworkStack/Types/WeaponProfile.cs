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
    public class WeaponProfile : IPackable
    {
        /// <summary>
        /// the type of damage done by the weapon
        /// </summary>
        [MessageProperty]
        public DamageType DamageType { get; set; }        
        
        /// <summary>
        /// the speed of the weapon
        /// </summary>
        [MessageProperty]
        public uint WeaponTime { get; set; }        
        
        /// <summary>
        /// the skill used by the weapon (-1 if none)
        /// </summary>
        [MessageProperty]
        public SkillID WeaponSkill { get; set; }        
        
        /// <summary>
        /// the maximum damage done by the weapon
        /// </summary>
        [MessageProperty]
        public uint WeaponDamage { get; set; }        
        
        /// <summary>
        /// the maximum damage variance of the weapon
        /// </summary>
        [MessageProperty]
        public double DamageVariance { get; set; }        
        
        /// <summary>
        /// the damage modifier of the weapon
        /// </summary>
        [MessageProperty]
        public double DamageMod { get; set; }        
        
        [MessageProperty]
        public double WeaponLength { get; set; }        
        
        /// <summary>
        /// the power of the weapon (this affects range)
        /// </summary>
        [MessageProperty]
        public double MaxVelocity { get; set; }        
        
        /// <summary>
        /// the attack skill bonus of the weapon
        /// </summary>
        [MessageProperty]
        public double WeaponOffense { get; set; }        
        
        [MessageProperty]
        public uint WeaponMaxVelocityEstimated { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            DamageType = (DamageType)reader.ReadUInt32();
            WeaponTime = reader.ReadUInt32();
            WeaponSkill = (SkillID)reader.ReadUInt32();
            WeaponDamage = reader.ReadUInt32();
            DamageVariance = reader.ReadDouble();
            DamageMod = reader.ReadDouble();
            WeaponLength = reader.ReadDouble();
            MaxVelocity = reader.ReadDouble();
            WeaponOffense = reader.ReadDouble();
            WeaponMaxVelocityEstimated = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)DamageType);
            writer.Write(WeaponTime);
            writer.Write((uint)WeaponSkill);
            writer.Write(WeaponDamage);
            writer.Write(DamageVariance);
            writer.Write(DamageMod);
            writer.Write(WeaponLength);
            writer.Write(MaxVelocity);
            writer.Write(WeaponOffense);
            writer.Write(WeaponMaxVelocityEstimated);

        }


    }
}

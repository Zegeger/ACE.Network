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
    /// The FellowInfo structure contains information about a fellowship member.
    /// </summary>
    public class Fellow : IPackable
    {
        /// <summary>
        /// Perhaps cp stored up before distribution?
        /// </summary>
        [MessageProperty]
        public uint CpCached { get; set; }        
        
        /// <summary>
        /// Perhaps lum stored up before distribution?
        /// </summary>
        [MessageProperty]
        public uint LumCached { get; set; }        
        
        /// <summary>
        /// level of member
        /// </summary>
        [MessageProperty]
        public uint Level { get; set; }        
        
        /// <summary>
        /// Maximum Health
        /// </summary>
        [MessageProperty]
        public uint MaxHealth { get; set; }        
        
        /// <summary>
        /// Maximum Stamina
        /// </summary>
        [MessageProperty]
        public uint MaxStamina { get; set; }        
        
        /// <summary>
        /// Maximum Mana
        /// </summary>
        [MessageProperty]
        public uint MaxMana { get; set; }        
        
        /// <summary>
        /// Current Health
        /// </summary>
        [MessageProperty]
        public uint CurrentHealth { get; set; }        
        
        /// <summary>
        /// Current Stamina
        /// </summary>
        [MessageProperty]
        public uint CurrentStamina { get; set; }        
        
        /// <summary>
        /// Current Mana
        /// </summary>
        [MessageProperty]
        public uint CurrentMana { get; set; }        
        
        /// <summary>
        /// if 0 then noSharePhatLoot, if 16 (0x0010) then sharePhatLoot
        /// </summary>
        [MessageProperty]
        public uint ShareLoot { get; set; }        
        
        /// <summary>
        /// Name of Member
        /// </summary>
        [MessageProperty]
        public string Name { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            CpCached = reader.ReadUInt32();
            LumCached = reader.ReadUInt32();
            Level = reader.ReadUInt32();
            MaxHealth = reader.ReadUInt32();
            MaxStamina = reader.ReadUInt32();
            MaxMana = reader.ReadUInt32();
            CurrentHealth = reader.ReadUInt32();
            CurrentStamina = reader.ReadUInt32();
            CurrentMana = reader.ReadUInt32();
            ShareLoot = reader.ReadUInt32();
            Name = reader.ReadString16L();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(CpCached);
            writer.Write(LumCached);
            writer.Write(Level);
            writer.Write(MaxHealth);
            writer.Write(MaxStamina);
            writer.Write(MaxMana);
            writer.Write(CurrentHealth);
            writer.Write(CurrentStamina);
            writer.Write(CurrentMana);
            writer.Write(ShareLoot);
            writer.WriteString16L(Name);

        }


    }
}

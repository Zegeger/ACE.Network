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
    /// The Skill structure contains information about a character skill.
    /// </summary>
    public class Skill : IPackable
    {
        /// <summary>
        /// points raised
        /// </summary>
        [MessageProperty]
        public ushort LevelFromPP { get; set; }        
        
        /// <summary>
        /// If this is not 0, it appears to trigger the initLevel to be treated as extra XP applied to the skill
        /// </summary>
        [MessageProperty]
        public ushort AdjustPP { get; set; }        
        
        /// <summary>
        /// skill state
        /// </summary>
        [MessageProperty]
        public SkillState Sac { get; set; }        
        
        /// <summary>
        /// XP spent on this skill
        /// </summary>
        [MessageProperty]
        public uint Pp { get; set; }        
        
        /// <summary>
        /// starting point for advancement of the skill (eg bonus points)
        /// </summary>
        [MessageProperty]
        public uint InitLevel { get; set; }        
        
        /// <summary>
        /// last use difficulty
        /// </summary>
        [MessageProperty]
        public uint ResistanceOfLastCheck { get; set; }        
        
        /// <summary>
        /// time skill was last used
        /// </summary>
        [MessageProperty]
        public double LastUsedTime { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            LevelFromPP = reader.ReadUInt16();
            AdjustPP = reader.ReadUInt16();
            Sac = (SkillState)reader.ReadUInt32();
            Pp = reader.ReadUInt32();
            InitLevel = reader.ReadUInt32();
            ResistanceOfLastCheck = reader.ReadUInt32();
            LastUsedTime = reader.ReadDouble();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(LevelFromPP);
            writer.Write(AdjustPP);
            writer.Write((uint)Sac);
            writer.Write(Pp);
            writer.Write(InitLevel);
            writer.Write(ResistanceOfLastCheck);
            writer.Write(LastUsedTime);

        }


    }
}

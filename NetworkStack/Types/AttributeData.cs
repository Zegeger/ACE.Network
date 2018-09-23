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
    /// The AttributeData structure contains information about a character attribute.
    /// </summary>
    public class AttributeData : IPackable
    {
        /// <summary>
        /// points raised
        /// </summary>
        [MessageProperty]
        public uint LevelFromCp { get; set; }        
        
        /// <summary>
        /// innate points
        /// </summary>
        [MessageProperty]
        public uint InitLevel { get; set; }        
        
        /// <summary>
        /// XP spent on this attribute
        /// </summary>
        [MessageProperty]
        public uint CpSpent { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            LevelFromCp = reader.ReadUInt32();
            InitLevel = reader.ReadUInt32();
            CpSpent = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(LevelFromCp);
            writer.Write(InitLevel);
            writer.Write(CpSpent);

        }


    }
}

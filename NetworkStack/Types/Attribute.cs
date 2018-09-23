using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;

namespace ACE.Network.Types
{
    /// <summary>
    /// The Attribute structure contains information about a character attribute.
    /// </summary>
    public class Attribute
    {
        /// <summary>
        /// points raised
        /// </summary>
        uint levelFromCp { get; set; }        
        
        /// <summary>
        /// innate points
        /// </summary>
        uint initLevel { get; set; }        
        
        /// <summary>
        /// XP spent on this attribute
        /// </summary>
        uint cpSpent { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            levelFromCp = reader.ReadUInt32();
            initLevel = reader.ReadUInt32();
            cpSpent = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(levelFromCp);
            writer.Write(initLevel);
            writer.Write(cpSpent);

        }
    }
}

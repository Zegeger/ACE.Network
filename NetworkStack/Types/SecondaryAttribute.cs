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
    /// The SecondaryAttribute structure contains information about a character vital.
    /// </summary>
    public class SecondaryAttribute : IPackable
    {
        /// <summary>
        /// secondary attribute's data
        /// </summary>
        [MessageProperty]
        public AttributeData Attribute { get; } = new AttributeData();
        
        /// <summary>
        /// current value of the vital
        /// </summary>
        [MessageProperty]
        public uint CurrentLevel { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Attribute.Unpack(reader);
            CurrentLevel = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            Attribute.Pack(writer);
            writer.Write(CurrentLevel);

        }


    }
}

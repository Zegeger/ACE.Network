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
    /// Information on stat modification
    /// </summary>
    public class StatMod : IPackable
    {
        /// <summary>
        /// flags that indicate the type of effect the spell has
        /// </summary>
        [MessageProperty]
        public uint Type { get; set; }        
        
        /// <summary>
        /// along with flags, indicates which attribute is affected by the spell
        /// </summary>
        [MessageProperty]
        public uint Key { get; set; }        
        
        /// <summary>
        /// the effect value/amount
        /// </summary>
        [MessageProperty]
        public float Value { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Type = reader.ReadUInt32();
            Key = reader.ReadUInt32();
            Value = reader.ReadSingle();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Type);
            writer.Write(Key);
            writer.Write(Value);

        }


    }
}

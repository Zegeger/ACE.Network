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
    /// Shortcut
    /// </summary>
    public class ShortCutData : IPackable
    {
        /// <summary>
        /// Position
        /// </summary>
        [MessageProperty]
        public uint Index { get; set; }        
        
        /// <summary>
        /// Object ID
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// May not have been used in prod?  Maybe a remnet of before spell tabs?  I don't think you could put spells in shortcut spot...
        /// </summary>
        [MessageProperty]
        public LayeredSpellID SpellID { get; } = new LayeredSpellID();
        


        public void Unpack(BinaryReader reader)
        {
            Index = reader.ReadUInt32();
            ObjectID = reader.ReadUInt32();
            SpellID.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Index);
            writer.Write(ObjectID);
            SpellID.Pack(writer);

        }


    }
}

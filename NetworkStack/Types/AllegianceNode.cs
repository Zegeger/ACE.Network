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
    /// Set of allegiance data for a specific player associated with their patron
    /// </summary>
    public class AllegianceNode : IPackable
    {
        /// <summary>
        /// The Object ID for the parent character to this character.  Used by the client to decide how to build the display in the Allegiance tab. 1 is the monarch.
        /// </summary>
        [MessageProperty]
        public uint TreeParent { get; set; }        
        
        [MessageProperty]
        public AllegianceData AllegianceData { get; } = new AllegianceData();
        


        public void Unpack(BinaryReader reader)
        {
            TreeParent = reader.ReadUInt32();
            AllegianceData.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(TreeParent);
            AllegianceData.Pack(writer);

        }


    }
}

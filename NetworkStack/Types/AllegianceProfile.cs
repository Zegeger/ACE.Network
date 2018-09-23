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
    /// Allegience information
    /// </summary>
    public class AllegianceProfile : IPackable
    {
        /// <summary>
        /// The number of allegiance members.
        /// </summary>
        [MessageProperty]
        public uint TotalMembers { get; set; }        
        
        /// <summary>
        /// Your personal number of followers.
        /// </summary>
        [MessageProperty]
        public uint TotalVassals { get; set; }        
        
        [MessageProperty]
        public AllegianceHierarchy AllegianceHierarchy { get; } = new AllegianceHierarchy();
        


        public void Unpack(BinaryReader reader)
        {
            TotalMembers = reader.ReadUInt32();
            TotalVassals = reader.ReadUInt32();
            AllegianceHierarchy.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(TotalMembers);
            writer.Write(TotalVassals);
            AllegianceHierarchy.Pack(writer);

        }


    }
}

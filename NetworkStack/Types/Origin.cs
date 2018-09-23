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
    /// Landcell location, without orientation
    /// </summary>
    public class Origin : IPackable
    {
        /// <summary>
        /// the landcell in which the object is located
        /// </summary>
        [MessageProperty]
        public uint Landcell { get; set; }        
        
        /// <summary>
        /// the location in the landcell for the object
        /// </summary>
        [MessageProperty]
        public Vector3 Vector { get; } = new Vector3();
        


        public void Unpack(BinaryReader reader)
        {
            Landcell = reader.ReadUInt32();
            Vector.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Landcell);
            Vector.Pack(writer);

        }


    }
}

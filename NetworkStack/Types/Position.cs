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
    /// Landcell location, including orientation
    /// </summary>
    public class Position : IPackable
    {
        /// <summary>
        /// the landcell in which the object is located
        /// </summary>
        [MessageProperty]
        public uint Landcell { get; set; }        
        
        /// <summary>
        /// the location and orientation in the landcell
        /// </summary>
        [MessageProperty]
        public Frame Frame { get; } = new Frame();
        


        public void Unpack(BinaryReader reader)
        {
            Landcell = reader.ReadUInt32();
            Frame.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Landcell);
            Frame.Pack(writer);

        }


    }
}

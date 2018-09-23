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
    /// Contains data for a subpalette
    /// </summary>
    public class Subpalette : IPackable
    {
        /// <summary>
        /// palette DataID (minus 0x04000000)
        /// </summary>
        [MessageProperty]
        public uint Palette { get; set; }        
        
        /// <summary>
        /// The number of palette entries to skip
        /// </summary>
        [MessageProperty]
        public byte Offset { get; set; }        
        
        /// <summary>
        /// The number of palette entries to copy. This is multiplied by 8.  If it is 0, it defaults to 256*8.
        /// </summary>
        [MessageProperty]
        public byte NumColors { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Palette = reader.ReadUIntCompressed16();
            Offset = reader.ReadByte();
            NumColors = reader.ReadByte();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.WriteUIntCompressed16(Palette);
            writer.Write(Offset);
            writer.Write(NumColors);

        }


    }
}

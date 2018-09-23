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
    /// Set of information related to a salvage of an item
    /// </summary>
    public class SalvageResult : IPackable
    {
        [MessageProperty]
        public MaterialType Material { get; set; }        
        
        [MessageProperty]
        public double Workmanship { get; set; }        
        
        [MessageProperty]
        public uint Units { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Material = (MaterialType)reader.ReadUInt32();
            Workmanship = reader.ReadDouble();
            Units = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Material);
            writer.Write(Workmanship);
            writer.Write(Units);

        }


    }
}

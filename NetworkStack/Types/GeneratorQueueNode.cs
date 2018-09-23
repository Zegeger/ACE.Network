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
    public class GeneratorQueueNode : IPackable
    {
        [MessageProperty]
        public uint Slot { get; set; }        
        
        [MessageProperty]
        public double When { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Slot = reader.ReadUInt32();
            When = reader.ReadDouble();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Slot);
            writer.Write(When);

        }


    }
}

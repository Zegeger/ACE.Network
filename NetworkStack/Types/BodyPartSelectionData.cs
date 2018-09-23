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
    public class BodyPartSelectionData : IPackable
    {
        [MessageProperty]
        public int HLF { get; set; }        
        
        [MessageProperty]
        public int MLF { get; set; }        
        
        [MessageProperty]
        public int LLF { get; set; }        
        
        [MessageProperty]
        public int HRF { get; set; }        
        
        [MessageProperty]
        public int MRF { get; set; }        
        
        [MessageProperty]
        public int LRF { get; set; }        
        
        [MessageProperty]
        public int HLB { get; set; }        
        
        [MessageProperty]
        public int MLB { get; set; }        
        
        [MessageProperty]
        public int LLB { get; set; }        
        
        [MessageProperty]
        public int HRB { get; set; }        
        
        [MessageProperty]
        public int MRB { get; set; }        
        
        [MessageProperty]
        public int LRB { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            HLF = reader.ReadInt32();
            MLF = reader.ReadInt32();
            LLF = reader.ReadInt32();
            HRF = reader.ReadInt32();
            MRF = reader.ReadInt32();
            LRF = reader.ReadInt32();
            HLB = reader.ReadInt32();
            MLB = reader.ReadInt32();
            LLB = reader.ReadInt32();
            HRB = reader.ReadInt32();
            MRB = reader.ReadInt32();
            LRB = reader.ReadInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(HLF);
            writer.Write(MLF);
            writer.Write(LLF);
            writer.Write(HRF);
            writer.Write(MRF);
            writer.Write(LRF);
            writer.Write(HLB);
            writer.Write(MLB);
            writer.Write(LLB);
            writer.Write(HRB);
            writer.Write(MRB);
            writer.Write(LRB);

        }


    }
}

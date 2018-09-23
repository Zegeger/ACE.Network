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
    public class GeneratorProfile : IPackable
    {
        [MessageProperty]
        public float Probability { get; set; }        
        
        [MessageProperty]
        public uint TypeID { get; set; }        
        
        [MessageProperty]
        public double Delay { get; set; }        
        
        [MessageProperty]
        public uint InitCreate { get; set; }        
        
        [MessageProperty]
        public uint MaxNum { get; set; }        
        
        [MessageProperty]
        public uint WhenCreate { get; set; }        
        
        [MessageProperty]
        public uint WhereCreate { get; set; }        
        
        [MessageProperty]
        public uint StackSize { get; set; }        
        
        [MessageProperty]
        public uint Ptid { get; set; }        
        
        [MessageProperty]
        public float Shade { get; set; }        
        
        [MessageProperty]
        public Position PosVal { get; } = new Position();
        
        [MessageProperty]
        public uint Slot { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Probability = reader.ReadSingle();
            TypeID = reader.ReadUInt32();
            Delay = reader.ReadDouble();
            InitCreate = reader.ReadUInt32();
            MaxNum = reader.ReadUInt32();
            WhenCreate = reader.ReadUInt32();
            WhereCreate = reader.ReadUInt32();
            StackSize = reader.ReadUInt32();
            Ptid = reader.ReadUInt32();
            Shade = reader.ReadSingle();
            PosVal.Unpack(reader);
            Slot = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Probability);
            writer.Write(TypeID);
            writer.Write(Delay);
            writer.Write(InitCreate);
            writer.Write(MaxNum);
            writer.Write(WhenCreate);
            writer.Write(WhereCreate);
            writer.Write(StackSize);
            writer.Write(Ptid);
            writer.Write(Shade);
            PosVal.Pack(writer);
            writer.Write(Slot);

        }


    }
}

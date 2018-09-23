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
    public class Quaternion : IPackable
    {
        [MessageProperty]
        public float W { get; set; }        
        
        [MessageProperty]
        public float X { get; set; }        
        
        [MessageProperty]
        public float Y { get; set; }        
        
        [MessageProperty]
        public float Z { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            W = reader.ReadSingle();
            X = reader.ReadSingle();
            Y = reader.ReadSingle();
            Z = reader.ReadSingle();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(W);
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);

        }


    }
}

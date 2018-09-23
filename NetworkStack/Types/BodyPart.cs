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
    /// Information on individual body parts. (Needs to be confirmed if this was used in prod)
    /// </summary>
    public class BodyPart : IPackable
    {
        [MessageProperty]
        public int HasBpsd { get; set; }        
        
        [MessageProperty]
        public int DType { get; set; }        
        
        [MessageProperty]
        public int DVal { get; set; }        
        
        [MessageProperty]
        public int DVar { get; set; }        
        
        /// <summary>
        /// Armor info
        /// </summary>
        [MessageProperty]
        public ArmorCache ACache { get; } = new ArmorCache();
        
        [MessageProperty]
        public int Bh { get; set; }        
        
        [MessageProperty]
        public BodyPartSelectionData Bpsd { get; } = new BodyPartSelectionData();
        


        public void Unpack(BinaryReader reader)
        {
            HasBpsd = reader.ReadInt32();
            DType = reader.ReadInt32();
            DVal = reader.ReadInt32();
            DVar = reader.ReadInt32();
            ACache.Unpack(reader);
            Bh = reader.ReadInt32();
            if((HasBpsd & 0x00000001) != 0)
            {
                Bpsd.Unpack(reader);
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(HasBpsd);
            writer.Write(DType);
            writer.Write(DVal);
            writer.Write(DVar);
            ACache.Pack(writer);
            writer.Write(Bh);
            if((HasBpsd & 0x00000001) != 0)
            {
                Bpsd.Pack(writer);
            }

        }


    }
}

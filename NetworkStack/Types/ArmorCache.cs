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
    /// Information on armor levels
    /// </summary>
    public class ArmorCache : IPackable
    {
        [MessageProperty]
        public int BaseArmor { get; set; }        
        
        [MessageProperty]
        public int ArmorVsSlash { get; set; }        
        
        [MessageProperty]
        public int ArmorVsPierce { get; set; }        
        
        [MessageProperty]
        public int ArmorVsBludgeon { get; set; }        
        
        [MessageProperty]
        public int ArmorVsCold { get; set; }        
        
        [MessageProperty]
        public int ArmorVsFire { get; set; }        
        
        [MessageProperty]
        public int ArmorVsAcid { get; set; }        
        
        [MessageProperty]
        public int ArmorVsElectric { get; set; }        
        
        [MessageProperty]
        public int ArmorVsNether { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            BaseArmor = reader.ReadInt32();
            ArmorVsSlash = reader.ReadInt32();
            ArmorVsPierce = reader.ReadInt32();
            ArmorVsBludgeon = reader.ReadInt32();
            ArmorVsCold = reader.ReadInt32();
            ArmorVsFire = reader.ReadInt32();
            ArmorVsAcid = reader.ReadInt32();
            ArmorVsElectric = reader.ReadInt32();
            ArmorVsNether = reader.ReadInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(BaseArmor);
            writer.Write(ArmorVsSlash);
            writer.Write(ArmorVsPierce);
            writer.Write(ArmorVsBludgeon);
            writer.Write(ArmorVsCold);
            writer.Write(ArmorVsFire);
            writer.Write(ArmorVsAcid);
            writer.Write(ArmorVsElectric);
            writer.Write(ArmorVsNether);

        }


    }
}

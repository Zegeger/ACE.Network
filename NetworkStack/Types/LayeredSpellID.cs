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
    /// Full spell ID combining the spell id with the spell layer.
    /// </summary>
    public class LayeredSpellID : IPackable
    {
        /// <summary>
        /// ID of the spell
        /// </summary>
        [MessageProperty]
        public ushort Id { get; set; }        
        
        /// <summary>
        /// Layer of the spell, seperating multiple instances of the same spell
        /// </summary>
        [MessageProperty]
        public ushort Layer { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Id = reader.ReadUInt16();
            Layer = reader.ReadUInt16();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Id);
            writer.Write(Layer);

        }


    }
}

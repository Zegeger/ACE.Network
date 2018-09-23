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
    /// Set of inventory items
    /// </summary>
    public class ContentProfile : IPackable
    {
        [MessageProperty]
        public uint Iid { get; set; }        
        
        /// <summary>
        /// Whether or not this object is a container.
        /// </summary>
        [MessageProperty]
        public ContainerProperties ContainerProperties { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Iid = reader.ReadUInt32();
            ContainerProperties = (ContainerProperties)reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Iid);
            writer.Write((uint)ContainerProperties);

        }


    }
}

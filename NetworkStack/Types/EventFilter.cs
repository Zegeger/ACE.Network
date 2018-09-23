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
    /// Contains a list of events to filter? Unknown what this does currently.
    /// </summary>
    public class EventFilter : IPackable
    {
        /// <summary>
        /// List of events
        /// </summary>
        [MessageProperty]
        public PackableList<uint> Filters { get; } = new PackableList<uint>(ReadFilters, WriteFilters);
        


        public void Unpack(BinaryReader reader)
        {
            Filters.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            Filters.Pack(writer);

        }

        static uint ReadFilters(BinaryReader reader)
        {
            var item = reader.ReadUInt32();
            return item;
        }
        
        static void WriteFilters(BinaryWriter writer, uint item)
        {
            writer.Write(item);
        }
        

    }
}

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
    /// Set of information related to a squelch entry
    /// </summary>
    public class SquelchInfo : IPackable
    {
        [MessageProperty]
        public PackableList<LogTextType> Filters { get; } = new PackableList<LogTextType>(ReadFilters, WriteFilters);
        
        /// <summary>
        /// the name of the squelched player
        /// </summary>
        [MessageProperty]
        public string Name { get; set; }        
        
        /// <summary>
        /// Whether this squelch applies to the entire account
        /// </summary>
        [MessageProperty]
        public bool Account { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Filters.Unpack(reader);
            Name = reader.ReadString16L();
            Account = reader.ReadBool32();

        }

        public void Pack(BinaryWriter writer)
        {
            Filters.Pack(writer);
            writer.WriteString16L(Name);
            writer.WriteBool32(Account);

        }

        static LogTextType ReadFilters(BinaryReader reader)
        {
            var item = (LogTextType)reader.ReadUInt32();
            return item;
        }
        
        static void WriteFilters(BinaryWriter writer, LogTextType item)
        {
            writer.Write((uint)item);
        }
        

    }
}

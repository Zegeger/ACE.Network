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
    /// Contains a list of emotes for NPCs? Unknown what this does currently.
    /// </summary>
    public class EmoteTable : IPackable
    {
        /// <summary>
        /// Key may be an EmoteCategory?
        /// </summary>
        [MessageProperty]
        public PackableHashTable<uint,EmoteSetList> Table { get; } = new PackableHashTable<uint,EmoteSetList>(ReadTable, WriteTable);
        


        public void Unpack(BinaryReader reader)
        {
            Table.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            Table.Pack(writer);

        }

        static KeyValuePair<uint, EmoteSetList> ReadTable(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = new EmoteSetList();
            val.Unpack(reader);
            return new KeyValuePair<uint, EmoteSetList>(key, val);
        }
        
        static void WriteTable(BinaryWriter writer, KeyValuePair<uint, EmoteSetList> pair)
        {
            writer.Write(pair.Key);
            pair.Value.Pack(writer);
        }
        

    }
}

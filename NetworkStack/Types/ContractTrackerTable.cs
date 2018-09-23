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
    /// Contains table of ContractTrackers
    /// </summary>
    public class ContractTrackerTable : IPackable
    {
        /// <summary>
        /// Set of contract trackers  with the contractID as the key and some additional info for them
        /// </summary>
        [MessageProperty]
        public PackableHashTable<uint,ContractTracker> ContactTrackers { get; } = new PackableHashTable<uint,ContractTracker>(ReadContactTrackers, WriteContactTrackers);
        


        public void Unpack(BinaryReader reader)
        {
            ContactTrackers.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            ContactTrackers.Pack(writer);

        }

        static KeyValuePair<uint, ContractTracker> ReadContactTrackers(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = new ContractTracker();
            val.Unpack(reader);
            return new KeyValuePair<uint, ContractTracker>(key, val);
        }
        
        static void WriteContactTrackers(BinaryWriter writer, KeyValuePair<uint, ContractTracker> pair)
        {
            writer.Write(pair.Key);
            pair.Value.Pack(writer);
        }
        

    }
}

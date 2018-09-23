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
    /// The RestrictionDB contains the access control list for a dwelling object.
    /// </summary>
    public class RestrictionDB : IPackable
    {
        /// <summary>
        /// 0 = private dwelling, 1 = open to public
        /// </summary>
        [MessageProperty]
        public uint Bitmask { get; set; }        
        
        /// <summary>
        /// allegiance monarch (if allegiance access granted)
        /// </summary>
        [MessageProperty]
        public uint MonarchID { get; set; }        
        
        /// <summary>
        /// Set of permissions on a per user basis. Key is the character id, value is 0 = dwelling access only, 1 = storage access also
        /// </summary>
        [MessageProperty]
        public PHashTable<uint,uint> Table { get; } = new PHashTable<uint,uint>(ReadTable, WriteTable);
        


        public void Unpack(BinaryReader reader)
        {
            var temp1 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
            if(temp1 != 0x10000002)
            {
                throw new Exception("Recieved value different from static on RestrictionDB, expected: 0x10000002, actual " + temp1);
            }
#endif
            Bitmask = reader.ReadUInt32();
            MonarchID = reader.ReadUInt32();
            Table.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)0x10000002); // Unused value
            writer.Write(Bitmask);
            writer.Write(MonarchID);
            Table.Pack(writer);

        }

        static KeyValuePair<uint, uint> ReadTable(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = reader.ReadUInt32();
            return new KeyValuePair<uint, uint>(key, val);
        }
        
        static void WriteTable(BinaryWriter writer, KeyValuePair<uint, uint> pair)
        {
            writer.Write(pair.Key);
            writer.Write(pair.Value);
        }
        

    }
}

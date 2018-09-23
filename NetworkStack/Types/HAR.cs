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
    /// Set of information related to house access
    /// </summary>
    public class HAR : IPackable
    {
        /// <summary>
        /// 0 is private house, 1 = open to public
        /// </summary>
        [MessageProperty]
        public uint Bitmask { get; set; }        
        
        /// <summary>
        /// populated when any allegiance access is specified
        /// </summary>
        [MessageProperty]
        public uint MonarchID { get; set; }        
        
        /// <summary>
        /// Set of guests with their ID as the key and some additional info for them
        /// </summary>
        [MessageProperty]
        public PackableHashTable<uint,GuestInfo> GuestList { get; } = new PackableHashTable<uint,GuestInfo>(ReadGuestList, WriteGuestList);
        
        /// <summary>
        /// List that has the ID's of your roommates
        /// </summary>
        [MessageProperty]
        public PList<uint> RoomMateList { get; } = new PList<uint>(ReadRoomMateList, WriteRoomMateList);
        


        public void Unpack(BinaryReader reader)
        {
            var temp1 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
            if(temp1 != 0x10000002)
            {
                throw new Exception("Recieved value different from static on HAR, expected: 0x10000002, actual " + temp1);
            }
#endif
            Bitmask = reader.ReadUInt32();
            MonarchID = reader.ReadUInt32();
            GuestList.Unpack(reader);
            RoomMateList.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)0x10000002); // Unused value
            writer.Write(Bitmask);
            writer.Write(MonarchID);
            GuestList.Pack(writer);
            RoomMateList.Pack(writer);

        }

        static KeyValuePair<uint, GuestInfo> ReadGuestList(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = new GuestInfo();
            val.Unpack(reader);
            return new KeyValuePair<uint, GuestInfo>(key, val);
        }
        
        static void WriteGuestList(BinaryWriter writer, KeyValuePair<uint, GuestInfo> pair)
        {
            writer.Write(pair.Key);
            pair.Value.Pack(writer);
        }
        
        static uint ReadRoomMateList(BinaryReader reader)
        {
            var item = reader.ReadUInt32();
            return item;
        }
        
        static void WriteRoomMateList(BinaryWriter writer, uint item)
        {
            writer.Write(item);
        }
        

    }
}

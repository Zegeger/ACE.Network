////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Types;
using ACE.Network.Extensions;

namespace ACE.Network.Messages
{
    /// <summary>
    /// Titles for the current character.
    /// </summary>
    public class CharacterTitleTableS2C : OrderedMessage
    {
        /// <summary>
        /// the title ID of the currently active title
        /// </summary>
        [MessageProperty]
        public uint DisplayTitle { get; set; }        
        
        /// <summary>
        /// Titles character currently has.
        /// </summary>
        [MessageProperty]
        public PList<uint> TitleList { get; } = new PList<uint>(ReadTitleList, WriteTitleList);
        


        public CharacterTitleTableS2C() : base((MessageType)0x0029, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public CharacterTitleTableS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            var temp1 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
            if(temp1 != 1)
            {
                throw new Exception("Recieved value different from static on CharacterTitleTableS2C, expected: 1, actual " + temp1);
            }
#endif
            DisplayTitle = reader.ReadUInt32();
            TitleList.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)1); // Unused value
            writer.Write(DisplayTitle);
            TitleList.Pack(writer);

        }

        static uint ReadTitleList(BinaryReader reader)
        {
            var item = reader.ReadUInt32();
            return item;
        }
        
        static void WriteTitleList(BinaryWriter writer, uint item)
        {
            writer.Write(item);
        }
        

    }
}

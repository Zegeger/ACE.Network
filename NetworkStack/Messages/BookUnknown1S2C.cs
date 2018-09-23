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
    /// Unknown purpose
    /// </summary>
    public class BookUnknown1S2C : OrderedMessage
    {
        /// <summary>
        /// The readable object being changed.
        /// </summary>
        [MessageProperty]
        public uint BookID { get; set; }        
        
        [MessageProperty]
        public uint Unknown1 { get; set; }        
        
        [MessageProperty]
        public bool Unknown2 { get; set; }        
        


        public BookUnknown1S2C() : base((MessageType)0x00B5, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public BookUnknown1S2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            BookID = reader.ReadUInt32();
            Unknown1 = reader.ReadUInt32();
            Unknown2 = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(BookID);
            writer.Write(Unknown1);
            writer.WriteBool32(Unknown2);

        }


    }
}

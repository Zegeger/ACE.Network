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
    /// Sets a character's display title
    /// </summary>
    public class SetDisplayCharacterTitleC2S : OrderedMessage
    {
        /// <summary>
        /// Title id
        /// </summary>
        [MessageProperty]
        public uint TitleID { get; set; }        
        


        public SetDisplayCharacterTitleC2S() : base((MessageType)0x002C, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SetDisplayCharacterTitleC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            TitleID = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(TitleID);

        }


    }
}

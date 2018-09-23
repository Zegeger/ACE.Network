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
    /// Mark a character for deletetion.
    /// </summary>
    public class CharacterDeleteC2S : Message
    {
        /// <summary>
        /// The account for the character
        /// </summary>
        [MessageProperty]
        public string Account { get; set; }        
        
        /// <summary>
        /// Slot to delete
        /// </summary>
        [MessageProperty]
        public int Slot { get; set; }        
        


        public CharacterDeleteC2S() : base((MessageType)0xF655, MessageDirection.ClientToServer, (Queues)0x00000004)
        { }

        public CharacterDeleteC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Account = reader.ReadString16L();
            Slot = reader.ReadInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Account);
            writer.Write(Slot);

        }


    }
}

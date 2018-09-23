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
    /// Failure to log in
    /// </summary>
    public class CharacterErrorS2C : Message
    {
        /// <summary>
        /// Identifies type of error
        /// </summary>
        [MessageProperty]
        public CharacterErrorType Reason { get; set; }        
        


        public CharacterErrorS2C() : base((MessageType)0xF659, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public CharacterErrorS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Reason = (CharacterErrorType)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Reason);

        }


    }
}

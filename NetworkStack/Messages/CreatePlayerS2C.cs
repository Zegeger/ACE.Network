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
    /// Login of player
    /// </summary>
    public class CreatePlayerS2C : Message
    {
        /// <summary>
        /// ID of the character logging on - should be you.
        /// </summary>
        [MessageProperty]
        public uint Character { get; set; }        
        


        public CreatePlayerS2C() : base((MessageType)0xF746, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public CreatePlayerS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Character = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Character);

        }


    }
}

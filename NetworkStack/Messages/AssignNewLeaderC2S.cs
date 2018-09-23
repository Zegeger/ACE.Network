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
    /// Fellowship Assign a new leader
    /// </summary>
    public class AssignNewLeaderC2S : OrderedMessage
    {
        /// <summary>
        /// ID of player to make the new leader of the fellowship
        /// </summary>
        [MessageProperty]
        public uint Target { get; set; }        
        


        public AssignNewLeaderC2S() : base((MessageType)0x0290, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public AssignNewLeaderC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Target = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Target);

        }


    }
}

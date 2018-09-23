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
    /// Performs a non autonomous jump
    /// </summary>
    public class JumpNonAutonomousC2S : OrderedMessage
    {
        /// <summary>
        /// Power of jump
        /// </summary>
        [MessageProperty]
        public float Extent { get; set; }        
        


        public JumpNonAutonomousC2S() : base((MessageType)0xF7C9, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public JumpNonAutonomousC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Extent = reader.ReadSingle();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Extent);

        }


    }
}

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
    /// Performs a jump
    /// </summary>
    public class JumpC2S : OrderedMessage
    {
        /// <summary>
        /// set of jumping data
        /// </summary>
        [MessageProperty]
        public JumpPack Jp { get; } = new JumpPack();
        


        public JumpC2S() : base((MessageType)0xF61B, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public JumpC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Jp.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Jp.Pack(writer);

        }


    }
}

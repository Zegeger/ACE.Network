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
    /// Move to state data
    /// </summary>
    public class MoveToStateC2S : OrderedMessage
    {
        /// <summary>
        /// set of move to data, currently not in client, may not be used?
        /// </summary>
        [MessageProperty]
        public MoveToStatePack Mtsp { get; } = new MoveToStatePack();
        


        public MoveToStateC2S() : base((MessageType)0xF61C, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public MoveToStateC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Mtsp.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Mtsp.Pack(writer);

        }


    }
}

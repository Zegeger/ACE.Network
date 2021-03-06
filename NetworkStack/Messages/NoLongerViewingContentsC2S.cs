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
    /// Stop viewing the contents of a container
    /// </summary>
    public class NoLongerViewingContentsC2S : OrderedMessage
    {
        /// <summary>
        /// ID of the container
        /// </summary>
        [MessageProperty]
        public uint Container { get; set; }        
        


        public NoLongerViewingContentsC2S() : base((MessageType)0x0195, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public NoLongerViewingContentsC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Container = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Container);

        }


    }
}

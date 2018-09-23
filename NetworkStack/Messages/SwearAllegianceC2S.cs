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
    /// Swear allegiance
    /// </summary>
    public class SwearAllegianceC2S : OrderedMessage
    {
        /// <summary>
        /// The person you are swearing allegiance to
        /// </summary>
        [MessageProperty]
        public uint Target { get; set; }        
        


        public SwearAllegianceC2S() : base((MessageType)0x001D, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SwearAllegianceC2S(BinaryReader reader) : this()
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

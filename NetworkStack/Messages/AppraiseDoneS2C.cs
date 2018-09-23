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
    /// Close Assess Panel
    /// </summary>
    public class AppraiseDoneS2C : OrderedMessage
    {
        /// <summary>
        /// Seems to always be 0. Client does not use it.
        /// </summary>
        [MessageProperty]
        public uint Unknown { get; set; }        
        


        public AppraiseDoneS2C() : base((MessageType)0x01CB, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public AppraiseDoneS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Unknown = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Unknown);

        }


    }
}

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
    /// UseDone: Ready. Previous action complete
    /// </summary>
    public class UseDoneS2C : OrderedMessage
    {
        [MessageProperty]
        public StatusMessage FailureType { get; set; }        
        


        public UseDoneS2C() : base((MessageType)0x01C7, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UseDoneS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            FailureType = (StatusMessage)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)FailureType);

        }


    }
}

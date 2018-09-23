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
    /// Account has been booted
    /// </summary>
    public class AccountBootedS2C : Message
    {
        [MessageProperty]
        public string ReasonText { get; set; }        
        


        public AccountBootedS2C() : base((MessageType)0xF7DC, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public AccountBootedS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ReasonText = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(ReasonText);

        }


    }
}

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
    /// HandleAttackDoneEvent: Melee attack completed
    /// </summary>
    public class HandleAttackDoneEventS2C : OrderedMessage
    {
        /// <summary>
        /// Number of user attacks, doesn't appear to be used by client
        /// </summary>
        [MessageProperty]
        public uint Number { get; set; }        
        


        public HandleAttackDoneEventS2C() : base((MessageType)0x01A7, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HandleAttackDoneEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Number = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Number);

        }


    }
}

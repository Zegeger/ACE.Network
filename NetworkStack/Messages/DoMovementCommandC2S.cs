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
    /// Performs a movement based on input
    /// </summary>
    public class DoMovementCommandC2S : OrderedMessage
    {
        /// <summary>
        /// motion command
        /// </summary>
        [MessageProperty]
        public uint Motion { get; set; }        
        
        /// <summary>
        /// speed of movement
        /// </summary>
        [MessageProperty]
        public float Speed { get; set; }        
        
        /// <summary>
        /// run key being held
        /// </summary>
        [MessageProperty]
        public uint HoldKey { get; set; }        
        


        public DoMovementCommandC2S() : base((MessageType)0xF61E, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public DoMovementCommandC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Motion = reader.ReadUInt32();
            Speed = reader.ReadSingle();
            HoldKey = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Motion);
            writer.Write(Speed);
            writer.Write(HoldKey);

        }


    }
}

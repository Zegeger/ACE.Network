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
    /// Stops a movement
    /// </summary>
    public class StopMovementCommandC2S : OrderedMessage
    {
        /// <summary>
        /// Motion being stopped
        /// </summary>
        [MessageProperty]
        public uint Motion { get; set; }        
        
        /// <summary>
        /// Key being held
        /// </summary>
        [MessageProperty]
        public uint HoldKey { get; set; }        
        


        public StopMovementCommandC2S() : base((MessageType)0xF661, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public StopMovementCommandC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Motion = reader.ReadUInt32();
            HoldKey = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Motion);
            writer.Write(HoldKey);

        }


    }
}

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
    /// Sends an autonomous position
    /// </summary>
    public class AutonomousPositionC2S : OrderedMessage
    {
        /// <summary>
        /// Set of autonomous position data
        /// </summary>
        [MessageProperty]
        public AutonomousPositionPack App { get; } = new AutonomousPositionPack();
        


        public AutonomousPositionC2S() : base((MessageType)0xF753, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public AutonomousPositionC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            App.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            App.Pack(writer);

        }


    }
}

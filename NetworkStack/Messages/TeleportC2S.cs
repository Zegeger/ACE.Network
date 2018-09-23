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
    /// Advocate Teleport
    /// </summary>
    public class TeleportC2S : OrderedMessage
    {
        /// <summary>
        /// Person being teleported
        /// </summary>
        [MessageProperty]
        public string Target { get; set; }        
        
        /// <summary>
        /// Destination to teleport target to
        /// </summary>
        [MessageProperty]
        public Position Dest { get; } = new Position();
        


        public TeleportC2S() : base((MessageType)0x00D6, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public TeleportC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Target = reader.ReadString16L();
            Dest.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Target);
            Dest.Pack(writer);

        }


    }
}

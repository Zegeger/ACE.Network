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
    /// A portal storm is imminent.
    /// </summary>
    public class PortalStormImminentS2C : OrderedMessage
    {
        /// <summary>
        /// Less than or equal to 0.0 resets timer, otherwise sets timer
        /// </summary>
        [MessageProperty]
        public float Extent { get; set; }        
        


        public PortalStormImminentS2C() : base((MessageType)0x02CA, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public PortalStormImminentS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Extent = reader.ReadSingle();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Extent);

        }


    }
}

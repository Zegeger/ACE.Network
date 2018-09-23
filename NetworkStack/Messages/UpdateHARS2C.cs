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
    /// House Guest List
    /// </summary>
    public class UpdateHARS2C : OrderedMessage
    {
        /// <summary>
        /// Set of house access records
        /// </summary>
        [MessageProperty]
        public HAR Har { get; } = new HAR();
        


        public UpdateHARS2C() : base((MessageType)0x0257, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateHARS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Har.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Har.Pack(writer);

        }


    }
}

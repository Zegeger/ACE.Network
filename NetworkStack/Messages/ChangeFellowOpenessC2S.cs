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
    /// Fellowship Change openness
    /// </summary>
    public class ChangeFellowOpenessC2S : OrderedMessage
    {
        /// <summary>
        /// Sets whether the fellowship is open or not
        /// </summary>
        [MessageProperty]
        public bool Open { get; set; }        
        


        public ChangeFellowOpenessC2S() : base((MessageType)0x0291, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ChangeFellowOpenessC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Open = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteBool32(Open);

        }


    }
}

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
    /// Modify whether house hooks are visibile or not, /house hooks on/off
    /// </summary>
    public class SetHooksVisibilityC2S : OrderedMessage
    {
        /// <summary>
        /// Whether hooks are visible or not
        /// </summary>
        [MessageProperty]
        public bool Visible { get; set; }        
        


        public SetHooksVisibilityC2S() : base((MessageType)0x0266, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SetHooksVisibilityC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Visible = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteBool32(Visible);

        }


    }
}

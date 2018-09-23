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
    /// Display a status message on the Action Viewscreen (the red text overlaid on the 3D area).
    /// </summary>
    public class TransientStringS2C : OrderedMessage
    {
        /// <summary>
        /// the message text
        /// </summary>
        [MessageProperty]
        public string Text { get; set; }        
        


        public TransientStringS2C() : base((MessageType)0x02EB, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public TransientStringS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Text = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Text);

        }


    }
}

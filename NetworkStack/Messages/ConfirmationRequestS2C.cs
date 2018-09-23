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
    /// Display a confirmation panel.
    /// </summary>
    public class ConfirmationRequestS2C : OrderedMessage
    {
        /// <summary>
        /// the type of confirmation panel to display
        /// </summary>
        [MessageProperty]
        public ConfirmationType ConfirmationType { get; set; }        
        
        /// <summary>
        /// sequence number
        /// </summary>
        [MessageProperty]
        public uint ContextID { get; set; }        
        
        /// <summary>
        /// text to be included in the confirmation panel message
        /// </summary>
        [MessageProperty]
        public string Text { get; set; }        
        


        public ConfirmationRequestS2C() : base((MessageType)0x0274, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ConfirmationRequestS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ConfirmationType = (ConfirmationType)reader.ReadUInt32();
            ContextID = reader.ReadUInt32();
            Text = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)ConfirmationType);
            writer.Write(ContextID);
            writer.WriteString16L(Text);

        }


    }
}

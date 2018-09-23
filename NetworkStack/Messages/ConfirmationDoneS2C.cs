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
    /// Confirmation done
    /// </summary>
    public class ConfirmationDoneS2C : OrderedMessage
    {
        /// <summary>
        /// the type of confirmation panel being closed
        /// </summary>
        [MessageProperty]
        public ConfirmationType ConfirmationType { get; set; }        
        
        /// <summary>
        /// sequence number
        /// </summary>
        [MessageProperty]
        public uint ContextID { get; set; }        
        


        public ConfirmationDoneS2C() : base((MessageType)0x0276, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ConfirmationDoneS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ConfirmationType = (ConfirmationType)reader.ReadUInt32();
            ContextID = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)ConfirmationType);
            writer.Write(ContextID);

        }


    }
}

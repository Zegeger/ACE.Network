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
    /// Confirms a dialog
    /// </summary>
    public class ConfirmationResponseC2S : OrderedMessage
    {
        [MessageProperty]
        public ConfirmationType ConfirmType { get; set; }        
        
        [MessageProperty]
        public uint Context { get; set; }        
        
        [MessageProperty]
        public bool Accepted { get; set; }        
        


        public ConfirmationResponseC2S() : base((MessageType)0x0275, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ConfirmationResponseC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ConfirmType = (ConfirmationType)reader.ReadUInt32();
            Context = reader.ReadUInt32();
            Accepted = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)ConfirmType);
            writer.Write(Context);
            writer.WriteBool32(Accepted);

        }


    }
}

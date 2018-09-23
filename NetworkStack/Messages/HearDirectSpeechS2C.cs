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
    /// Someone has sent you a @tell.
    /// </summary>
    public class HearDirectSpeechS2C : OrderedMessage
    {
        /// <summary>
        /// the message text
        /// </summary>
        [MessageProperty]
        public string Msg { get; set; }        
        
        /// <summary>
        /// the name of the creature sending you the message
        /// </summary>
        [MessageProperty]
        public string Sender { get; set; }        
        
        /// <summary>
        /// the object ID of the creature sending you the message
        /// </summary>
        [MessageProperty]
        public uint SenderID { get; set; }        
        
        /// <summary>
        /// the object ID of the recipient of the message (should be you)
        /// </summary>
        [MessageProperty]
        public uint TargetID { get; set; }        
        
        /// <summary>
        /// the message type, controls color and @filter processing
        /// </summary>
        [MessageProperty]
        public ChatMessageType Type { get; set; }        
        
        /// <summary>
        /// doesn't seem to be used by the client
        /// </summary>
        [MessageProperty]
        public uint SecretFlags { get; set; }        
        


        public HearDirectSpeechS2C() : base((MessageType)0x02BD, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HearDirectSpeechS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Msg = reader.ReadString16L();
            Sender = reader.ReadString16L();
            SenderID = reader.ReadUInt32();
            TargetID = reader.ReadUInt32();
            Type = (ChatMessageType)reader.ReadUInt32();
            SecretFlags = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Msg);
            writer.WriteString16L(Sender);
            writer.Write(SenderID);
            writer.Write(TargetID);
            writer.Write((uint)Type);
            writer.Write(SecretFlags);

        }


    }
}

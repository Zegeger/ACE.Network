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
    /// Failure to give an item
    /// </summary>
    public class ServerSaysAttemptFailedS2C : OrderedMessage
    {
        /// <summary>
        /// Item that could not be given
        /// </summary>
        [MessageProperty]
        public uint ItemID { get; set; }        
        
        /// <summary>
        /// Failure reason code
        /// </summary>
        [MessageProperty]
        public StatusMessage Reason { get; set; }        
        


        public ServerSaysAttemptFailedS2C() : base((MessageType)0x00A0, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ServerSaysAttemptFailedS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ItemID = reader.ReadUInt32();
            Reason = (StatusMessage)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ItemID);
            writer.Write((uint)Reason);

        }


    }
}

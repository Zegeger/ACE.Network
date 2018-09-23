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
    /// Update Rent Time
    /// </summary>
    public class UpdateRentTimeS2C : OrderedMessage
    {
        /// <summary>
        /// when the current maintenance period began (Unix timestamp)
        /// </summary>
        [MessageProperty]
        public uint RentTime { get; set; }        
        


        public UpdateRentTimeS2C() : base((MessageType)0x0227, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateRentTimeS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            RentTime = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(RentTime);

        }


    }
}

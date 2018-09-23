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
    /// Give an item to someone.
    /// </summary>
    public class GiveObjectRequestC2S : OrderedMessage
    {
        /// <summary>
        /// The recipient of the item
        /// </summary>
        [MessageProperty]
        public uint TargetID { get; set; }        
        
        /// <summary>
        /// The item being given
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// The amount from a stack being given
        /// </summary>
        [MessageProperty]
        public uint Amount { get; set; }        
        


        public GiveObjectRequestC2S() : base((MessageType)0x00CD, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public GiveObjectRequestC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            TargetID = reader.ReadUInt32();
            ObjectID = reader.ReadUInt32();
            Amount = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(TargetID);
            writer.Write(ObjectID);
            writer.Write(Amount);

        }


    }
}

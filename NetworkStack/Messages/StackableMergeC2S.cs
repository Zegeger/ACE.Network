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
    /// Merges one stack with another
    /// </summary>
    public class StackableMergeC2S : OrderedMessage
    {
        /// <summary>
        /// ID of object where items are being taken from
        /// </summary>
        [MessageProperty]
        public uint MergeFromID { get; set; }        
        
        /// <summary>
        /// ID of object where items are being merged into
        /// </summary>
        [MessageProperty]
        public uint MergeToID { get; set; }        
        
        /// <summary>
        /// Number of items from the source stack to be added to the destination stack
        /// </summary>
        [MessageProperty]
        public uint Amount { get; set; }        
        


        public StackableMergeC2S() : base((MessageType)0x0054, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public StackableMergeC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            MergeFromID = reader.ReadUInt32();
            MergeToID = reader.ReadUInt32();
            Amount = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(MergeFromID);
            writer.Write(MergeToID);
            writer.Write(Amount);

        }


    }
}

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
    /// Split a stack and place it into the world
    /// </summary>
    public class StackableSplitTo3DC2S : OrderedMessage
    {
        /// <summary>
        /// ID of object where items are being taken from
        /// </summary>
        [MessageProperty]
        public uint StackID { get; set; }        
        
        /// <summary>
        /// Number of items from the stack to placed into the world
        /// </summary>
        [MessageProperty]
        public uint Amount { get; set; }        
        


        public StackableSplitTo3DC2S() : base((MessageType)0x0056, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public StackableSplitTo3DC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            StackID = reader.ReadUInt32();
            Amount = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(StackID);
            writer.Write(Amount);

        }


    }
}

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
    /// Attempt to use an item with a target.
    /// </summary>
    public class UseWithTargetEventC2S : OrderedMessage
    {
        /// <summary>
        /// The item being used
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// The target
        /// </summary>
        [MessageProperty]
        public uint Target { get; set; }        
        


        public UseWithTargetEventC2S() : base((MessageType)0x0035, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public UseWithTargetEventC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            Target = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write(Target);

        }


    }
}

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
    /// Sets a new fill complevel for a component
    /// </summary>
    public class SetDesiredComponentLevelC2S : OrderedMessage
    {
        /// <summary>
        /// class id of the component
        /// </summary>
        [MessageProperty]
        public uint Wcid { get; set; }        
        
        [MessageProperty]
        public uint Amount { get; set; }        
        


        public SetDesiredComponentLevelC2S() : base((MessageType)0x0224, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SetDesiredComponentLevelC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Wcid = reader.ReadUInt32();
            Amount = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Wcid);
            writer.Write(Amount);

        }


    }
}

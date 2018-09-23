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
    /// Sets an autonomy level
    /// </summary>
    public class AutonomyLevelC2S : OrderedMessage
    {
        /// <summary>
        /// Seems to be 0, 1 or 2. I think 0/1 is server controlled, 2 is client controlled
        /// </summary>
        [MessageProperty]
        public uint Level { get; set; }        
        


        public AutonomyLevelC2S() : base((MessageType)0xF752, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public AutonomyLevelC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Level = reader.ReadUInt32();
            reader.Align();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Level);
            writer.Align();

        }


    }
}

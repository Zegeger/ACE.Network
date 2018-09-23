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
    /// A Player Kill occurred nearby (also sent for suicides).
    /// </summary>
    public class HandlePlayerDeathEventS2C : Message
    {
        /// <summary>
        /// The death message
        /// </summary>
        [MessageProperty]
        public string Msg { get; set; }        
        
        /// <summary>
        /// The ID of the departed.
        /// </summary>
        [MessageProperty]
        public uint Killed { get; set; }        
        
        /// <summary>
        /// The ID of the character doing the killing.
        /// </summary>
        [MessageProperty]
        public uint Killer { get; set; }        
        


        public HandlePlayerDeathEventS2C() : base((MessageType)0x019E, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HandlePlayerDeathEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Msg = reader.ReadString16L();
            Killed = reader.ReadUInt32();
            Killer = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Msg);
            writer.Write(Killed);
            writer.Write(Killer);

        }


    }
}

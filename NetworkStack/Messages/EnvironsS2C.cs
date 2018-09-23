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
    /// This appears to be an admin command to change the environment (light, fog, sounds, colors)
    /// </summary>
    public class EnvironsS2C : Message
    {
        /// <summary>
        /// ID of option set to change the environs
        /// </summary>
        [MessageProperty]
        public EnvrionChangeType EnvrionsOptions { get; set; }        
        


        public EnvironsS2C() : base((MessageType)0xEA60, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public EnvironsS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            EnvrionsOptions = (EnvrionChangeType)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)EnvrionsOptions);

        }


    }
}

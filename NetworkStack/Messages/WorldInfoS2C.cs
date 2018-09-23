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
    /// The name of the current world.
    /// </summary>
    public class WorldInfoS2C : Message
    {
        /// <summary>
        /// the number of players connected
        /// </summary>
        [MessageProperty]
        public uint Connections { get; set; }        
        
        /// <summary>
        /// the max number of players allowed to connect
        /// </summary>
        [MessageProperty]
        public uint MaxConnections { get; set; }        
        
        /// <summary>
        /// the name of the current world
        /// </summary>
        [MessageProperty]
        public string WorldName { get; set; }        
        


        public WorldInfoS2C() : base((MessageType)0xF7E1, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public WorldInfoS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Connections = reader.ReadUInt32();
            MaxConnections = reader.ReadUInt32();
            WorldName = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Connections);
            writer.Write(MaxConnections);
            writer.WriteString16L(WorldName);

        }


    }
}

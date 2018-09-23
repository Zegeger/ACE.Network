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
    /// Joins a chess game
    /// </summary>
    public class JoinC2S : OrderedMessage
    {
        /// <summary>
        /// ID of the game the player is joining
        /// </summary>
        [MessageProperty]
        public uint GameID { get; set; }        
        
        /// <summary>
        /// Which team the player is joining as
        /// </summary>
        [MessageProperty]
        public uint WhichTeam { get; set; }        
        


        public JoinC2S() : base((MessageType)0x0269, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public JoinC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            GameID = reader.ReadUInt32();
            WhichTeam = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(GameID);
            writer.Write(WhichTeam);

        }


    }
}

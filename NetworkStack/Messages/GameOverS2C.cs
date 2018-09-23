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
    /// End of Chess game
    /// </summary>
    public class GameOverS2C : OrderedMessage
    {
        [MessageProperty]
        public uint IdGame { get; set; }        
        
        /// <summary>
        /// Which team was the winner for this game
        /// </summary>
        [MessageProperty]
        public int TeamWinner { get; set; }        
        


        public GameOverS2C() : base((MessageType)0x028C, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public GameOverS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            IdGame = reader.ReadUInt32();
            TeamWinner = reader.ReadInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(IdGame);
            writer.Write(TeamWinner);

        }


    }
}

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
    /// Opponent Turn
    /// </summary>
    public class OpponentTurnS2C : OrderedMessage
    {
        /// <summary>
        /// Some kind of identifier for this game
        /// </summary>
        [MessageProperty]
        public uint IdGame { get; set; }        
        
        /// <summary>
        /// Team making this move
        /// </summary>
        [MessageProperty]
        public int Team { get; set; }        
        
        /// <summary>
        /// Data related to the piece move
        /// </summary>
        [MessageProperty]
        public GameMoveData GameMoveData { get; } = new GameMoveData();
        


        public OpponentTurnS2C() : base((MessageType)0x0284, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public OpponentTurnS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            IdGame = reader.ReadUInt32();
            Team = reader.ReadInt32();
            GameMoveData.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(IdGame);
            writer.Write(Team);
            GameMoveData.Pack(writer);

        }


    }
}

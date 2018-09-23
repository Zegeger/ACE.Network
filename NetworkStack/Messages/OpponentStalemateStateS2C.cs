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
    /// Opponent Stalemate State
    /// </summary>
    public class OpponentStalemateStateS2C : OrderedMessage
    {
        /// <summary>
        /// Some kind of identifier for this game
        /// </summary>
        [MessageProperty]
        public uint IdGame { get; set; }        
        
        /// <summary>
        /// Team
        /// </summary>
        [MessageProperty]
        public int Team { get; set; }        
        
        /// <summary>
        /// 1 = offering stalemate, 0 = retracting stalemate
        /// </summary>
        [MessageProperty]
        public bool On { get; set; }        
        


        public OpponentStalemateStateS2C() : base((MessageType)0x0285, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public OpponentStalemateStateS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            IdGame = reader.ReadUInt32();
            Team = reader.ReadInt32();
            On = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(IdGame);
            writer.Write(Team);
            writer.WriteBool32(On);

        }


    }
}

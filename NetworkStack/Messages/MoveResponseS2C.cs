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
    /// Move response
    /// </summary>
    public class MoveResponseS2C : OrderedMessage
    {
        /// <summary>
        /// Some kind of identifier for this game
        /// </summary>
        [MessageProperty]
        public uint IdGame { get; set; }        
        
        /// <summary>
        /// If less than or equal to 0, then failure
        /// </summary>
        [MessageProperty]
        public ChessMoveResult MoveResult { get; set; }        
        


        public MoveResponseS2C() : base((MessageType)0x0283, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public MoveResponseS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            IdGame = reader.ReadUInt32();
            MoveResult = (ChessMoveResult)reader.ReadInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(IdGame);
            writer.Write((int)MoveResult);

        }


    }
}

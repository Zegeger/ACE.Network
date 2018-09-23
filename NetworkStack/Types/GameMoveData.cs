////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;

namespace ACE.Network.Types
{
    /// <summary>
    /// Set of information related to a chess game move
    /// </summary>
    public class GameMoveData : IPackable
    {
        /// <summary>
        /// Type of move
        /// </summary>
        [MessageProperty]
        public int Type { get; set; }        
        
        /// <summary>
        /// Player making the move
        /// </summary>
        [MessageProperty]
        public uint PlayerID { get; set; }        
        
        /// <summary>
        /// Team making this move
        /// </summary>
        [MessageProperty]
        public int Team { get; set; }        
        
        /// <summary>
        /// ID of piece being moved
        /// </summary>
        [MessageProperty]
        public int IdPieceToMove { get; set; }        
        
        [MessageProperty]
        public int YGrid { get; set; }        
        
        /// <summary>
        /// x position to move the piece
        /// </summary>
        [MessageProperty]
        public int XTo { get; set; }        
        
        /// <summary>
        /// y position to move the piece
        /// </summary>
        [MessageProperty]
        public int YTo { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Type = reader.ReadInt32();
            PlayerID = reader.ReadUInt32();
            Team = reader.ReadInt32();
            switch(Type)
            {
                case 0x4:
                    IdPieceToMove = reader.ReadInt32();
                    YGrid = reader.ReadInt32();
                break;
                case 0x5:
                    IdPieceToMove = reader.ReadInt32();
                    YGrid = reader.ReadInt32();
                    XTo = reader.ReadInt32();
                    YTo = reader.ReadInt32();
                break;
                case 0x6:
                    IdPieceToMove = reader.ReadInt32();
                break;
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Type);
            writer.Write(PlayerID);
            writer.Write(Team);
            switch(Type)
            {
                case 0x4:
                    writer.Write(IdPieceToMove);
                    writer.Write(YGrid);
                break;
                case 0x5:
                    writer.Write(IdPieceToMove);
                    writer.Write(YGrid);
                    writer.Write(XTo);
                    writer.Write(YTo);
                break;
                case 0x6:
                    writer.Write(IdPieceToMove);
                break;
            }

        }


    }
}

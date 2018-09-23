////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    /// <summary>
    /// Identifies the chess move attempt result.  Negative/0 values are failures.
    /// </summary>
    public enum ChessMoveResult : int
    {
        
        /// <summary>
        /// Its not your turn, please wait for your opponents move.
        /// </summary>
        FailureNotYourTurn = -0x00000003,
        
        /// <summary>
        /// The selected piece cannot move that direction
        /// </summary>
        FailureInvalidDirection = -0x00000064,
        
        /// <summary>
        /// The selected piece cannot move that far
        /// </summary>
        FailureInvalidDistance = -0x00000065,
        
        /// <summary>
        /// You tried to move an empty square
        /// </summary>
        FailureMovingEmptySquare = -0x00000066,
        
        /// <summary>
        /// The selected piece is not yours
        /// </summary>
        FailureMovingOpponentPiece = -0x00000067,
        
        /// <summary>
        /// You cannot move off the board
        /// </summary>
        FailureMovedPieceOffBoard = -0x00000068,
        
        /// <summary>
        /// You cannot attack your own pieces
        /// </summary>
        FailureAttackingOwnPiece = -0x00000069,
        
        /// <summary>
        /// That move would put you in check
        /// </summary>
        FailureCannotMoveIntoCheck = -0x0000006A,
        
        /// <summary>
        /// You can only move through empty squares
        /// </summary>
        FailurePathBlocked = -0x0000006B,
        
        /// <summary>
        /// You cannot castle out of check
        /// </summary>
        FailureCastleOutOfCheck = -0x0000006C,
        
        /// <summary>
        /// You cannot castle through check
        /// </summary>
        FailureCastleThroughCheck = -0x0000006D,
        
        /// <summary>
        /// You cannot castle after moving the King or Rook
        /// </summary>
        FailureCastlePieceMoved = -0x0000006E,
        
        /// <summary>
        /// That move is invalid
        /// </summary>
        FailureInvalidMove = 0x00000000,
        
        /// <summary>
        /// Successful move.
        /// </summary>
        Success = 0x00000001,
        
        /// <summary>
        /// Your opponent is in Check.
        /// </summary>
        OpponentInCheck = 0x00000400,
        
        /// <summary>
        /// You have checkmated your opponent!
        /// </summary>
        CheckMatedOpponent = 0x00000800
    }
}

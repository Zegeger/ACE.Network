////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    /// <summary>
    /// The movement type defines the fields for the rest of the message
    /// </summary>
    public enum MovementType : byte
    {
        InterpertedMotionState = 0x00,
        MoveToObject = 0x06,
        MoveToPosition = 0x07,
        TurnToObject = 0x08,
        TurnToPosition = 0x09
    }
}

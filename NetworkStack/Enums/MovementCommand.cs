////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    /// <summary>
    /// The movement (forward, side, turn) for a character or monster.
    /// </summary>
    public enum MovementCommand : ushort
    {
        HoldRun = 0x0001,
        HoldSidestep = 0x0002,
        WalkForward = 0x0005,
        WalkBackwards = 0x0006,
        RunForward = 0x0007,
        TurnRight = 0x000D,
        TurnLeft = 0x000E,
        SideStepRight = 0x000F,
        SideStepLeft = 0x0010
    }
}

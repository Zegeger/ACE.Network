////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    /// <summary>
    /// Stage a contract is in.  Values 4+ appear to provide contract specific update messages
    /// </summary>
    public enum ContractStage : uint
    {
        New = 0x00000001,
        InProgress = 0x00000002,
        
        /// <summary>
        /// If this is set, it looks at the time when repeats to show either Done, Available, or # to Repeat
        /// </summary>
        DoneOrPendingRepeat = 0x00000003
    }
}

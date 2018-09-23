////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    public enum Queues : uint
    {
        
        /// <summary>
        /// C2S, small number of admin messages and a few others
        /// </summary>
        Control = 0x00000002,
        
        /// <summary>
        /// C2S, most all game actions, all ordered
        /// </summary>
        Weenie = 0x00000003,
        
        /// <summary>
        /// Bidirectional, login messages, turbine chat
        /// </summary>
        Logon = 0x00000004,
        
        /// <summary>
        /// Bidirectional, DAT patching
        /// </summary>
        CLCache = 0x00000005,
        
        /// <summary>
        /// S2C, game events (ordered) and other character related messages
        /// </summary>
        UIQueue = 0x00000009,
        
        /// <summary>
        /// S2C, messages mostly related to object creation/deletion and their motion, effects
        /// </summary>
        SmartBox = 0x0000000A
    }
}

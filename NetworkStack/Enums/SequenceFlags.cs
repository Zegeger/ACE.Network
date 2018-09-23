////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    public enum SequenceFlags : byte
    {
        
        /// <summary>
        /// Sent on most all messages
        /// </summary>
        Unknown1 = 0x01,
        
        /// <summary>
        /// Sent on most all messages
        /// </summary>
        Unknown2 = 0x02,
        
        /// <summary>
        /// Client sends this on any messages that are not queue 4,5,8
        /// </summary>
        Unknown20 = 0x20,
        
        /// <summary>
        /// Indicates the fragment is ephemeral, meaning if a more recent instance exists, it will be replaced.
        /// </summary>
        Ephemeral = 0x80
    }
}

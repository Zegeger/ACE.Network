////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    public enum AuthType : uint
    {
        
        /// <summary>
        /// Set initially on init
        /// </summary>
        None = 0x00000001,
        
        /// <summary>
        /// Set if we're using a VGPassword
        /// </summary>
        VGPassword = 0x00000002,
        
        /// <summary>
        /// Set if we're using a GLS ticket
        /// </summary>
        GLSTicket = 0x40000002
    }
}

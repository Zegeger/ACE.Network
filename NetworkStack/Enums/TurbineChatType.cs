////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    /// <summary>
    /// The TurbineChatType identifies the type of Turbine Chat message.
    /// </summary>
    public enum TurbineChatType : uint
    {
        ServerToClientMessage = 0x00000001,
        ClientToServerMessage = 0x00000003,
        AckClientToServerMessage = 0x00000005
    }
}

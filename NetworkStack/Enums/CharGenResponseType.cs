////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    /// <summary>
    /// The type response to a chargen request
    /// </summary>
    public enum CharGenResponseType : uint
    {
        OK = 0x00000001,
        NameInUse = 0x00000003,
        NameBanned = 0x00000004,
        Corrupt1 = 0x00000005,
        Corrupt2 = 0x00000006,
        AdminPrivilegeDenied = 0x00000007
    }
}

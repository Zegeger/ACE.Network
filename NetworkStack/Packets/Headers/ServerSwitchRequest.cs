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
using ACE.Network.Types;

namespace ACE.Network.Packets.Headers
{
    /// <summary>
    /// Sent by the client to the Socket provided in the referral to start a server switch
    /// </summary>
    public class ServerSwitchRequest
    {
        /// <summary>
        /// Cookie value sent in the referral.
        /// </summary>
        [MessageProperty]
        public ulong QwCookie { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            QwCookie = reader.ReadUInt64();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(QwCookie);

        }
    }
}

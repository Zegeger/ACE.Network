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
    /// Sent by the client to acknowledge the request.  This is the last in the 3-way handshake formed with LoginRequest, ConnectRequest, ConnectAck
    /// </summary>
    public class ConnectAck
    {
        /// <summary>
        /// Cookie matching the one passed in the ConnectRequest
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

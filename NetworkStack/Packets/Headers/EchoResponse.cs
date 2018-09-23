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
    /// Pong. Sent in response to the EchoRequest by the server.
    /// </summary>
    public class EchoResponse
    {
        /// <summary>
        /// Client time in the EchoRequest
        /// </summary>
        [MessageProperty]
        public float Clienttime { get; set; }        
        
        /// <summary>
        /// Delta
        /// </summary>
        [MessageProperty]
        public float Delta { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Clienttime = reader.ReadSingle();
            Delta = reader.ReadSingle();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Clienttime);
            writer.Write(Delta);

        }
    }
}

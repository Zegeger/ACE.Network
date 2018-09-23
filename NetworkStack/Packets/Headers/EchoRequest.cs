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
    /// Ping. Sent by client every 6 intervals (3 seconds)
    /// </summary>
    public class EchoRequest
    {
        /// <summary>
        /// Current client time
        /// </summary>
        [MessageProperty]
        public float Clienttime { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Clienttime = reader.ReadSingle();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Clienttime);

        }
    }
}

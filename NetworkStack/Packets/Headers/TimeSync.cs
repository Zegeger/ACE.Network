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
    /// Used to detect speed hacking
    /// </summary>
    public class TimeSync
    {
        /// <summary>
        /// Current server time
        /// </summary>
        [MessageProperty]
        public double Srvtime { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Srvtime = reader.ReadDouble();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Srvtime);

        }
    }
}

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
    /// Structure sending the bytes recieved during a particular interval.  Each time the remote interval changes, this is sent.
    /// </summary>
    public class Flow
    {
        /// <summary>
        /// Number of bytes received during this interval.  This is the sum of the total byte size of each packet received.
        /// </summary>
        [MessageProperty]
        public uint BytesReceived { get; set; }        
        
        /// <summary>
        /// Interval for which this byte count covers.
        /// </summary>
        [MessageProperty]
        public ushort Interval { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            BytesReceived = reader.ReadUInt32();
            Interval = reader.ReadUInt16();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(BytesReceived);
            writer.Write(Interval);

        }
    }
}

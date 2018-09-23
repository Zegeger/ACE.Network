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
    /// Sent by the server to direct the client to a new world server
    /// </summary>
    public class Referral
    {
        /// <summary>
        /// Cookie value.  First DWORD appears to be a high resolution time stamp.
        /// </summary>
        [MessageProperty]
        public ulong QwCookie { get; set; }        
        
        [MessageProperty]
        public SockAddrIn Addr { get; } = new SockAddrIn();
        
        /// <summary>
        /// The assigned ID value for this connection, this sets the packet header recId value to be used from here on out.
        /// </summary>
        [MessageProperty]
        public uint IdServer { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            QwCookie = reader.ReadUInt64();
            Addr.Unpack(reader);
            IdServer = reader.ReadUInt32();
            reader.Align();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(QwCookie);
            Addr.Pack(writer);
            writer.Write(IdServer);
            writer.Align();

        }
    }
}

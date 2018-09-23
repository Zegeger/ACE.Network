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
    /// Sent by the server to indicate the login was approved and the client can connect.  This is the second in the 3-way handshake formed with LoginRequest, ConnectRequest, ConnectAck
    /// </summary>
    public class ConnectRequest
    {
        /// <summary>
        /// Initial server time value
        /// </summary>
        [MessageProperty]
        public float ServerTime { get; set; }        
        
        /// <summary>
        /// Cookie value for this referral
        /// </summary>
        [MessageProperty]
        public ulong QwCookie { get; set; }        
        
        /// <summary>
        /// The assigned ID value for this connection, this sets the packet header recId value to be used from here on out.
        /// </summary>
        [MessageProperty]
        public uint NetID { get; set; }        
        
        /// <summary>
        /// Crypto value to seed for outgoing messages
        /// </summary>
        [MessageProperty]
        public uint OutgoingSeed { get; set; }        
        
        /// <summary>
        /// Crypto value to seed for incoming messages
        /// </summary>
        [MessageProperty]
        public uint IncomingSeed { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            ServerTime = reader.ReadSingle();
            QwCookie = reader.ReadUInt64();
            NetID = reader.ReadUInt32();
            OutgoingSeed = reader.ReadUInt32();
            IncomingSeed = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(ServerTime);
            writer.Write(QwCookie);
            writer.Write(NetID);
            writer.Write(OutgoingSeed);
            writer.Write(IncomingSeed);

        }
    }
}

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
    /// Sent by the client to start logging into the world.  This starts a 3-way handshake formed with LoginRequest, ConnectRequest, ConnectResponse
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Number of bytes following this.
        /// </summary>
        [MessageProperty]
        public uint ByteSize { get; set; }        
        
        /// <summary>
        /// Sets the type of auth to be used.  We used GLS in production.
        /// </summary>
        [MessageProperty]
        public AuthType AuthType { get; set; }        
        
        /// <summary>
        /// Some kind of flag setting options.
        /// </summary>
        [MessageProperty]
        public uint AuthFlags { get; set; }        
        
        /// <summary>
        /// Current Unix Timestamp for the client.
        /// </summary>
        [MessageProperty]
        public uint ConnectionSequenceNumber { get; set; }        
        
        /// <summary>
        /// Account name
        /// </summary>
        [MessageProperty]
        public string Account { get; set; }        
        
        /// <summary>
        /// I'm guessing this is used in some administrative fashion from a special client.  Does not see to be used in our production clients.
        /// </summary>
        [MessageProperty]
        public string AccountToLogonAs { get; set; }        
        
        /// <summary>
        /// This appears to be unused
        /// </summary>
        [MessageProperty]
        public GrowBufferStreamPack CryptoData { get; } = new GrowBufferStreamPack();
        
        /// <summary>
        /// Client seems to pass our GLS ticket in this location.
        /// </summary>
        [MessageProperty]
        public GrowBufferStreamPack ExtraData { get; } = new GrowBufferStreamPack();
        


        public void Unpack(BinaryReader reader)
        {
            var temp1 = reader.ReadString16L(); // Unused value
#if NETWORKVALIDATION
            if(temp1 != "1802")
            {
                throw new Exception("Recieved value different from static on LoginRequest, expected: 1802, actual " + temp1);
            }
#endif
            ByteSize = reader.ReadUInt32();
            AuthType = (AuthType)reader.ReadUInt32();
            AuthFlags = reader.ReadUInt32();
            ConnectionSequenceNumber = reader.ReadUInt32();
            Account = reader.ReadString16L();
            if((AuthFlags & 0x00000002) != 0)
            {
                AccountToLogonAs = reader.ReadString16L();
            }
            CryptoData.Unpack(reader);
            ExtraData.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.WriteString16L("1802"); // Unused value
            writer.Write(ByteSize);
            writer.Write((uint)AuthType);
            writer.Write(AuthFlags);
            writer.Write(ConnectionSequenceNumber);
            writer.WriteString16L(Account);
            if((AuthFlags & 0x00000002) != 0)
            {
                writer.WriteString16L(AccountToLogonAs);
            }
            CryptoData.Pack(writer);
            ExtraData.Pack(writer);

        }
    }
}

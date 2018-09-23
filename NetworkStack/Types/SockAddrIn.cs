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

namespace ACE.Network.Types
{
    public class SockAddrIn : IPackable
    {
        /// <summary>
        /// Port
        /// </summary>
        [MessageProperty]
        public ushort Port { get; set; }        
        
        /// <summary>
        /// IP Address
        /// </summary>
        [MessageProperty]
        public inAddr Addr { get; } = new inAddr();
        


        public void Unpack(BinaryReader reader)
        {
            var temp1 = reader.ReadInt16(); // Unused value
#if NETWORKVALIDATION
            if(temp1 != 2)
            {
                throw new Exception("Recieved value different from static on SockAddrIn, expected: 2, actual " + temp1);
            }
#endif
            Port = reader.ReadUInt16();
            Addr.Unpack(reader);
            var temp2 = reader.ReadUInt64(); // Unused value
#if NETWORKVALIDATION
            if(temp2 != 0)
            {
                throw new Exception("Recieved value different from static on SockAddrIn, expected: 0, actual " + temp2);
            }
#endif

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((short)2); // Unused value
            writer.Write(Port);
            Addr.Pack(writer);
            writer.Write((ulong)0); // Unused value

        }


    }
}

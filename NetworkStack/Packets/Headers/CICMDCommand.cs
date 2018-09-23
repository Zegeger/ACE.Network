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
    /// Some kind of command from client to server.  Sent every 220 intervals with noOp command.
    /// </summary>
    public class CICMDCommand
    {


        public void Unpack(BinaryReader reader)
        {
            var temp1 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
            if(temp1 != 0x1)
            {
                throw new Exception("Recieved value different from static on CICMDCommand, expected: 0x1, actual " + temp1);
            }
#endif
            var temp2 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
            if(temp2 != 0x0)
            {
                throw new Exception("Recieved value different from static on CICMDCommand, expected: 0x0, actual " + temp2);
            }
#endif

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)0x1); // Unused value
            writer.Write((uint)0x0); // Unused value

        }
    }
}

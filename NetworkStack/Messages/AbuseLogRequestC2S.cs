////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Types;
using ACE.Network.Extensions;

namespace ACE.Network.Messages
{
    /// <summary>
    /// Sends an abuse report.
    /// </summary>
    public class AbuseLogRequestC2S : OrderedMessage
    {
        /// <summary>
        /// Name of character
        /// </summary>
        [MessageProperty]
        public string Target { get; set; }        
        
        /// <summary>
        /// Description of complaint
        /// </summary>
        [MessageProperty]
        public string Complaint { get; set; }        
        


        public AbuseLogRequestC2S() : base((MessageType)0x0140, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public AbuseLogRequestC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Target = reader.ReadString16L();
            var temp1 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
            if(temp1 != 1)
            {
                throw new Exception("Recieved value different from static on AbuseLogRequestC2S, expected: 1, actual " + temp1);
            }
#endif
            Complaint = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Target);
            writer.Write((uint)1); // Unused value
            writer.WriteString16L(Complaint);

        }


    }
}

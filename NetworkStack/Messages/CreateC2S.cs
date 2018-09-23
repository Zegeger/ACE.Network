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
    /// Create a fellowship
    /// </summary>
    public class CreateC2S : OrderedMessage
    {
        /// <summary>
        /// Name of the fellowship
        /// </summary>
        [MessageProperty]
        public string Name { get; set; }        
        
        /// <summary>
        /// Whether fellowship shares xp
        /// </summary>
        [MessageProperty]
        public bool ShareXP { get; set; }        
        


        public CreateC2S() : base((MessageType)0x00A2, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public CreateC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Name = reader.ReadString16L();
            ShareXP = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Name);
            writer.WriteBool32(ShareXP);

        }


    }
}

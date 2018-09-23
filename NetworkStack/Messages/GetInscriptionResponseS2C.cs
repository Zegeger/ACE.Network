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
    /// Get Inscription Response, doesn't seem to be really used by client
    /// </summary>
    public class GetInscriptionResponseS2C : OrderedMessage
    {
        /// <summary>
        /// The inscription comment
        /// </summary>
        [MessageProperty]
        public string Inscription { get; set; }        
        
        /// <summary>
        /// The name of the inscription author.
        /// </summary>
        [MessageProperty]
        public string ScribeName { get; set; }        
        
        [MessageProperty]
        public string ScribeAccount { get; set; }        
        


        public GetInscriptionResponseS2C() : base((MessageType)0x00C3, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public GetInscriptionResponseS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Inscription = reader.ReadString16L();
            ScribeName = reader.ReadString16L();
            ScribeAccount = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Inscription);
            writer.WriteString16L(ScribeName);
            writer.WriteString16L(ScribeAccount);

        }


    }
}

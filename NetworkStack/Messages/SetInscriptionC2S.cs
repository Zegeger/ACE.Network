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
    /// Sets the inscription on an object
    /// </summary>
    public class SetInscriptionC2S : OrderedMessage
    {
        /// <summary>
        /// ID of object being inscribed
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// Inscription text
        /// </summary>
        [MessageProperty]
        public string Inscription { get; set; }        
        


        public SetInscriptionC2S() : base((MessageType)0x00BF, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SetInscriptionC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            Inscription = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.WriteString16L(Inscription);

        }


    }
}

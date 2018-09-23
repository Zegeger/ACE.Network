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
    /// QueryAgeResponse: happens when you do /age in the game
    /// </summary>
    public class QueryAgeResponseS2C : OrderedMessage
    {
        /// <summary>
        /// Name of target, or empty if self
        /// </summary>
        [MessageProperty]
        public string TargetName { get; set; }        
        
        /// <summary>
        /// Your age in the format 1mo 1d 1h 1m 1s
        /// </summary>
        [MessageProperty]
        public string Age { get; set; }        
        


        public QueryAgeResponseS2C() : base((MessageType)0x01C3, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public QueryAgeResponseS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            TargetName = reader.ReadString16L();
            Age = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(TargetName);
            writer.WriteString16L(Age);

        }


    }
}

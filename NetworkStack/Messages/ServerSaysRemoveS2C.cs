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
    /// Sent every time an object you are aware of ceases to exist. Merely running out of range does not generate this message - in that case, the client just automatically stops tracking it after receiving no updates for a while (which I presume is a very short while).
    /// </summary>
    public class ServerSaysRemoveS2C : Message
    {
        /// <summary>
        /// The object that ceases to exist.
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        


        public ServerSaysRemoveS2C() : base((MessageType)0x0024, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ServerSaysRemoveS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);

        }


    }
}

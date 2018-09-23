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
    /// Close Container - Only sent when explicitly closed
    /// </summary>
    public class StopViewingObjectContentsS2C : OrderedMessage
    {
        /// <summary>
        /// Chest or corpse being closed
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        


        public StopViewingObjectContentsS2C() : base((MessageType)0x0052, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public StopViewingObjectContentsS2C(BinaryReader reader) : this()
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

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
    /// Buy a dwelling or pay maintenance
    /// </summary>
    public class HouseProfileS2C : OrderedMessage
    {
        /// <summary>
        /// the object ID of the dwelling's covenant crystal
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        [MessageProperty]
        public HouseProfile Profile { get; } = new HouseProfile();
        


        public HouseProfileS2C() : base((MessageType)0x021D, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HouseProfileS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            Profile.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            Profile.Pack(writer);

        }


    }
}

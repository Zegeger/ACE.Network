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
    /// Sent whenever a character changes their clothes. It contains the entire description of what their wearing (and possibly their facial features as well). This message is only sent for changes, when the character is first created, the body of this message is included inside the creation message.
    /// </summary>
    public class ObjDescEventS2C : Message
    {
        /// <summary>
        /// The ID of character whose visual description is changing.
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// Set of visual description information for the object
        /// </summary>
        [MessageProperty]
        public ObjDesc ObjDesc { get; } = new ObjDesc();
        
        /// <summary>
        /// The instance sequence value for the object (number of logins for players)
        /// </summary>
        [MessageProperty]
        public ushort ObjectInstanceSequence { get; set; }        
        
        /// <summary>
        /// The position sequence value for the object
        /// </summary>
        [MessageProperty]
        public ushort ObjectVisualDescSequence { get; set; }        
        


        public ObjDescEventS2C() : base((MessageType)0xF625, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public ObjDescEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            ObjDesc.Unpack(reader);
            ObjectInstanceSequence = reader.ReadUInt16();
            ObjectVisualDescSequence = reader.ReadUInt16();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            ObjDesc.Pack(writer);
            writer.Write(ObjectInstanceSequence);
            writer.Write(ObjectVisualDescSequence);

        }


    }
}

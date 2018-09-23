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
    /// Sets the parent for an object, eg. equipting an object.
    /// </summary>
    public class ParentEventS2C : Message
    {
        /// <summary>
        /// id of the parent object
        /// </summary>
        [MessageProperty]
        public uint ParentID { get; set; }        
        
        /// <summary>
        /// id of the child object
        /// </summary>
        [MessageProperty]
        public uint ChildID { get; set; }        
        
        /// <summary>
        /// Location object is being equipt to (Read from CSetup table in dat)
        /// </summary>
        [MessageProperty]
        public uint ChildLocation { get; set; }        
        
        /// <summary>
        /// Placement frame id
        /// </summary>
        [MessageProperty]
        public uint PlacementID { get; set; }        
        
        /// <summary>
        /// The instance sequence value for the parent object (number of logins for players)
        /// </summary>
        [MessageProperty]
        public ushort ObjectInstanceSequence { get; set; }        
        
        /// <summary>
        /// The position sequence value for the child object
        /// </summary>
        [MessageProperty]
        public ushort ChildPositionSequence { get; set; }        
        


        public ParentEventS2C() : base((MessageType)0xF749, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public ParentEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ParentID = reader.ReadUInt32();
            ChildID = reader.ReadUInt32();
            ChildLocation = reader.ReadUInt32();
            PlacementID = reader.ReadUInt32();
            ObjectInstanceSequence = reader.ReadUInt16();
            ChildPositionSequence = reader.ReadUInt16();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ParentID);
            writer.Write(ChildID);
            writer.Write(ChildLocation);
            writer.Write(PlacementID);
            writer.Write(ObjectInstanceSequence);
            writer.Write(ChildPositionSequence);

        }


    }
}

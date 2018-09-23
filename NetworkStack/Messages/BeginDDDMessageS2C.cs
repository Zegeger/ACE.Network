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
    /// A list of dat files that need to be patched
    /// </summary>
    public class BeginDDDMessageS2C : Message
    {
        /// <summary>
        /// Amount of data expected
        /// </summary>
        [MessageProperty]
        public uint DataExpected { get; set; }        
        
        /// <summary>
        /// Total number of revisions to follow
        /// </summary>
        [MessageProperty]
        public uint RevisionCount { get; set; }        
        
        [MessageProperty]
        public List<DDDRevision> Revisions { get; } = new List<DDDRevision>();
        


        public BeginDDDMessageS2C() : base((MessageType)0xF7E7, MessageDirection.ServerToClient, (Queues)0x00000005)
        { }

        public BeginDDDMessageS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            DataExpected = reader.ReadUInt32();
            RevisionCount = reader.ReadUInt32();
            Revisions.Clear();
            for(int i = 0; i < RevisionCount; i++)
            {
                DDDRevision newItem = new DDDRevision();
                newItem.Unpack(reader);
                Revisions.Add(newItem);
            }

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(DataExpected);
            writer.Write(RevisionCount);
            for(int i = 0; i < RevisionCount; i++)
            {
                Revisions[i].Pack(writer);
            }

        }


    }
}

////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;
using ACE.Network.Types;

namespace ACE.Network.Packets.Headers
{
    /// <summary>
    /// List of sequences that are unable to be retransmitted.
    /// </summary>
    public class EmptyAck
    {
        /// <summary>
        /// Number of sequences
        /// </summary>
        [MessageProperty]
        public uint NumNaks { get; set; }        
        
        [MessageProperty]
        public List<uint> SeqIDs { get; } = new List<uint>();
        


        public void Unpack(BinaryReader reader)
        {
            NumNaks = reader.ReadUInt32();
            SeqIDs.Clear();
            for(int i = 0; i < NumNaks; i++)
            {
                SeqIDs.Add(reader.ReadUInt32());
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(NumNaks);
            for(int i = 0; i < NumNaks; i++)
            {
                writer.Write(SeqIDs[i]);
            }

        }
    }
}

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
    /// Indicates reception up to the sequence specified.
    /// </summary>
    public class Pak
    {
        /// <summary>
        /// Sequence ID, this and all previous ID's have been received.
        /// </summary>
        [MessageProperty]
        public uint SeqID { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            SeqID = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(SeqID);

        }
    }
}

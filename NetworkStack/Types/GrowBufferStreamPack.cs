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

namespace ACE.Network.Types
{
    /// <summary>
    /// A buffer which stores string bytes
    /// </summary>
    public class GrowBufferStreamPack : IPackable
    {
        /// <summary>
        /// Size of the object being packed.
        /// </summary>
        [MessageProperty]
        public uint ByteSize { get; set; }        
        
        /// <summary>
        /// Buffer of bytes
        /// </summary>
        [MessageProperty]
        public string Buffer { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            ByteSize = reader.ReadUInt32();
            if(ByteSize > 0)
            {
                Buffer = reader.ReadPString();
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(ByteSize);
            if(ByteSize > 0)
            {
                writer.WritePString(Buffer);
            }

        }


    }
}

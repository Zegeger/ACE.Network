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
    /// Contains information for a revision
    /// </summary>
    public class DDDRevision : IPackable
    {
        /// <summary>
        /// Type of DAT file being revised
        /// </summary>
        [MessageProperty]
        public uint DatFileType { get; set; }        
        
        
        /// <summary>
        /// The corresponding Dat file revision for this patch set
        /// </summary>
        [MessageProperty]
        public uint IdIteration { get; set; }        
        
        /// <summary>
        /// Number of resources to add in this revision
        /// </summary>
        [MessageProperty]
        public uint IDsToDownloadCount { get; set; }        
        
        /// <summary>
        /// the resource ID numbers to download
        /// </summary>
        [MessageProperty]
        public List<uint> IDsToDownload { get; } = new List<uint>();
        
        /// <summary>
        /// Number of resources to purge in this revision
        /// </summary>
        [MessageProperty]
        public uint IDsToPurgeCount { get; set; }        
        
        /// <summary>
        /// the resource ID numbers to purge
        /// </summary>
        [MessageProperty]
        public List<uint> IDsToPurge { get; } = new List<uint>();
        


        public void Unpack(BinaryReader reader)
        {
            ulong IdDatFile = reader.ReadUInt64();
            DatFileType = (uint)(IdDatFile >> 32);
            IdIteration = reader.ReadUInt32();
            IDsToDownloadCount = reader.ReadUInt32();
            IDsToDownload.Clear();
            for(int i = 0; i < IDsToDownloadCount; i++)
            {
                IDsToDownload.Add(reader.ReadUInt32());
            }
            IDsToPurgeCount = reader.ReadUInt32();
            IDsToPurge.Clear();
            for(int i = 0; i < IDsToPurgeCount; i++)
            {
                IDsToPurge.Add(reader.ReadUInt32());
            }

        }

        public void Pack(BinaryWriter writer)
        {
            ulong IdDatFile = 0;
            IdDatFile |= (ulong)(DatFileType << 32);
            writer.Write(IdDatFile);
            writer.Write(IdIteration);
            writer.Write(IDsToDownloadCount);
            for(int i = 0; i < IDsToDownloadCount; i++)
            {
                writer.Write(IDsToDownload[i]);
            }
            writer.Write(IDsToPurgeCount);
            for(int i = 0; i < IDsToPurgeCount; i++)
            {
                writer.Write(IDsToPurge[i]);
            }

        }


    }
}

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
    /// Add or update a dat file Resource.
    /// </summary>
    public class DataMessageS2C : Message
    {
        /// <summary>
        /// which dat file should store this resource
        /// </summary>
        [MessageProperty]
        public ResourceType IdDatFile { get; set; }        
        
        /// <summary>
        /// the resource type
        /// </summary>
        [MessageProperty]
        public uint ResourceType { get; set; }        
        
        /// <summary>
        /// the resource ID number
        /// </summary>
        [MessageProperty]
        public uint ResourceId { get; set; }        
        
        /// <summary>
        /// the file version number
        /// </summary>
        [MessageProperty]
        public uint IdIteration { get; set; }        
        
        /// <summary>
        /// the type of compression used
        /// </summary>
        [MessageProperty]
        public CompressionType Compression { get; set; }        
        
        /// <summary>
        /// version of some sort
        /// </summary>
        [MessageProperty]
        public uint Version { get; set; }        
        
        /// <summary>
        /// the number of bytes required for the remainder of this message, including this DWORD
        /// </summary>
        [MessageProperty]
        public uint DataSize { get; set; }        
        
        /// <summary>
        /// (dataSize-4) bytes of uncompressed file data
        /// </summary>
        [MessageProperty]
        public byte[] Data { get; set; }        
        
        /// <summary>
        /// the size of the uncompressed file
        /// </summary>
        [MessageProperty]
        public uint FileSize { get; set; }        
        


        public DataMessageS2C() : base((MessageType)0xF7E2, MessageDirection.ServerToClient, (Queues)0x00000005)
        { }

        public DataMessageS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            IdDatFile = (ResourceType)reader.ReadInt64();
            ResourceType = reader.ReadUInt32();
            ResourceId = reader.ReadUInt32();
            IdIteration = reader.ReadUInt32();
            Compression = (CompressionType)reader.ReadByte();
            Version = reader.ReadUInt32();
            DataSize = reader.ReadUInt32();
            switch(Compression)
            {
                case CompressionType.None:
                    Data = new byte[DataSize - 4];
                    for(int i = 0; i < DataSize - 4; i++)
                    {
                        Data[i] = reader.ReadByte();
                    }
                break;
                case CompressionType.ZLib:
                    FileSize = reader.ReadUInt32();
                    Data = new byte[DataSize - 8];
                    for(int i = 0; i < DataSize - 8; i++)
                    {
                        Data[i] = reader.ReadByte();
                    }
                break;
            }

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((long)IdDatFile);
            writer.Write(ResourceType);
            writer.Write(ResourceId);
            writer.Write(IdIteration);
            writer.Write((byte)Compression);
            writer.Write(Version);
            writer.Write(DataSize);
            switch(Compression)
            {
                case CompressionType.None:
                    for(int i = 0; i < DataSize - 4; i++)
                    {
                        writer.Write(Data);
                    }
                break;
                case CompressionType.ZLib:
                    writer.Write(FileSize);
                    for(int i = 0; i < DataSize - 8; i++)
                    {
                        writer.Write(Data);
                    }
                break;
            }

        }


    }
}

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
    /// Send or receive a message using Turbine Chat.
    /// </summary>
    public class TurbineChatS2C : Message
    {
        /// <summary>
        /// the number of bytes that follow after this DWORD
        /// </summary>
        [MessageProperty]
        public uint MessageSize { get; set; }        
        
        /// <summary>
        /// the type of data contained in this message
        /// </summary>
        [MessageProperty]
        public TurbineChatType Type { get; set; }        
        
        [MessageProperty]
        public uint BlobDispatchType { get; set; }        
        
        [MessageProperty]
        public int TargetType { get; set; }        
        
        [MessageProperty]
        public int TargetID { get; set; }        
        
        [MessageProperty]
        public int TransportType { get; set; }        
        
        [MessageProperty]
        public int TransportID { get; set; }        
        
        [MessageProperty]
        public int Cookie { get; set; }        
        
        /// <summary>
        /// the number of bytes that follow after this DWORD
        /// </summary>
        [MessageProperty]
        public uint PayloadSize { get; set; }        
        
        /// <summary>
        /// the channel number of the message
        /// </summary>
        [MessageProperty]
        public uint RoomID { get; set; }        
        
        /// <summary>
        /// the name of the player sending the message
        /// </summary>
        [MessageProperty]
        public string DisplayName { get; set; }        
        
        /// <summary>
        /// the message text
        /// </summary>
        [MessageProperty]
        public string Text { get; set; }        
        
        /// <summary>
        /// the number of bytes that follow after this DWORD
        /// </summary>
        [MessageProperty]
        public uint ExtraDataSize { get; set; }        
        
        /// <summary>
        /// the object ID of the player sending the message
        /// </summary>
        [MessageProperty]
        public uint SpeakerID { get; set; }        
        
        [MessageProperty]
        public int HResult { get; set; }        
        
        [MessageProperty]
        public uint ChatType { get; set; }        
        
        [MessageProperty]
        public uint ContextID { get; set; }        
        
        /// <summary>
        /// the channel name of the message
        /// </summary>
        [MessageProperty]
        public string RoomName { get; set; }        
        


        public TurbineChatS2C() : base((MessageType)0xF7DE, MessageDirection.ServerToClient, (Queues)0x00000004)
        { }

        public TurbineChatS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            MessageSize = reader.ReadUInt32();
            Type = (TurbineChatType)reader.ReadUInt32();
            BlobDispatchType = reader.ReadUInt32();
            TargetType = reader.ReadInt32();
            TargetID = reader.ReadInt32();
            TransportType = reader.ReadInt32();
            TransportID = reader.ReadInt32();
            Cookie = reader.ReadInt32();
            PayloadSize = reader.ReadUInt32();
            switch(Type)
            {
                case TurbineChatType.ServerToClientMessage:
                    switch(BlobDispatchType)
                    {
                        case 0x01:
                            RoomID = reader.ReadUInt32();
                            DisplayName = reader.ReadWString();
                            Text = reader.ReadWString();
                            ExtraDataSize = reader.ReadUInt32();
                            SpeakerID = reader.ReadUInt32();
                            HResult = reader.ReadInt32();
                            ChatType = reader.ReadUInt32();
                        break;
                    }
                break;
                case TurbineChatType.ClientToServerMessage:
                    switch(BlobDispatchType)
                    {
                        case 0x01:
                            ContextID = reader.ReadUInt32();
                            var temp1 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
                            if(temp1 != 1)
                            {
                                throw new Exception("Recieved value different from static on TurbineChatS2C, expected: 1, actual " + temp1);
                            }
#endif
                            var temp2 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
                            if(temp2 != 1)
                            {
                                throw new Exception("Recieved value different from static on TurbineChatS2C, expected: 1, actual " + temp2);
                            }
#endif
                            RoomName = reader.ReadWString();
                            Text = reader.ReadWString();
                            ExtraDataSize = reader.ReadUInt32();
                            SpeakerID = reader.ReadUInt32();
                            HResult = reader.ReadInt32();
                            ChatType = reader.ReadUInt32();
                        break;
                        case 0x02:
                            ContextID = reader.ReadUInt32();
                            var temp3 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
                            if(temp3 != 2)
                            {
                                throw new Exception("Recieved value different from static on TurbineChatS2C, expected: 2, actual " + temp3);
                            }
#endif
                            var temp4 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
                            if(temp4 != 2)
                            {
                                throw new Exception("Recieved value different from static on TurbineChatS2C, expected: 2, actual " + temp4);
                            }
#endif
                            RoomID = reader.ReadUInt32();
                            Text = reader.ReadWString();
                            ExtraDataSize = reader.ReadUInt32();
                            SpeakerID = reader.ReadUInt32();
                            HResult = reader.ReadInt32();
                            ChatType = reader.ReadUInt32();
                        break;
                    }
                break;
                case TurbineChatType.AckClientToServerMessage:
                    switch(BlobDispatchType)
                    {
                        case 0x01:
                            ContextID = reader.ReadUInt32();
                            var temp5 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
                            if(temp5 != 1)
                            {
                                throw new Exception("Recieved value different from static on TurbineChatS2C, expected: 1, actual " + temp5);
                            }
#endif
                            var temp6 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
                            if(temp6 != 1)
                            {
                                throw new Exception("Recieved value different from static on TurbineChatS2C, expected: 1, actual " + temp6);
                            }
#endif
                            HResult = reader.ReadInt32();
                        break;
                        case 0x02:
                            ContextID = reader.ReadUInt32();
                            var temp7 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
                            if(temp7 != 2)
                            {
                                throw new Exception("Recieved value different from static on TurbineChatS2C, expected: 2, actual " + temp7);
                            }
#endif
                            var temp8 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
                            if(temp8 != 2)
                            {
                                throw new Exception("Recieved value different from static on TurbineChatS2C, expected: 2, actual " + temp8);
                            }
#endif
                            HResult = reader.ReadInt32();
                        break;
                    }
                break;
            }

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(MessageSize);
            writer.Write((uint)Type);
            writer.Write(BlobDispatchType);
            writer.Write(TargetType);
            writer.Write(TargetID);
            writer.Write(TransportType);
            writer.Write(TransportID);
            writer.Write(Cookie);
            writer.Write(PayloadSize);
            switch(Type)
            {
                case TurbineChatType.ServerToClientMessage:
                    switch(BlobDispatchType)
                    {
                        case 0x01:
                            writer.Write(RoomID);
                            writer.WriteWString(DisplayName);
                            writer.WriteWString(Text);
                            writer.Write(ExtraDataSize);
                            writer.Write(SpeakerID);
                            writer.Write(HResult);
                            writer.Write(ChatType);
                        break;
                    }
                break;
                case TurbineChatType.ClientToServerMessage:
                    switch(BlobDispatchType)
                    {
                        case 0x01:
                            writer.Write(ContextID);
                            writer.Write((uint)1); // Unused value
                            writer.Write((uint)1); // Unused value
                            writer.WriteWString(RoomName);
                            writer.WriteWString(Text);
                            writer.Write(ExtraDataSize);
                            writer.Write(SpeakerID);
                            writer.Write(HResult);
                            writer.Write(ChatType);
                        break;
                        case 0x02:
                            writer.Write(ContextID);
                            writer.Write((uint)2); // Unused value
                            writer.Write((uint)2); // Unused value
                            writer.Write(RoomID);
                            writer.WriteWString(Text);
                            writer.Write(ExtraDataSize);
                            writer.Write(SpeakerID);
                            writer.Write(HResult);
                            writer.Write(ChatType);
                        break;
                    }
                break;
                case TurbineChatType.AckClientToServerMessage:
                    switch(BlobDispatchType)
                    {
                        case 0x01:
                            writer.Write(ContextID);
                            writer.Write((uint)1); // Unused value
                            writer.Write((uint)1); // Unused value
                            writer.Write(HResult);
                        break;
                        case 0x02:
                            writer.Write(ContextID);
                            writer.Write((uint)2); // Unused value
                            writer.Write((uint)2); // Unused value
                            writer.Write(HResult);
                        break;
                    }
                break;
            }

        }


    }
}

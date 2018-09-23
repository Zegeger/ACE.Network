using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Types;
using ACE.Network.Extensions;
using System.Text;

namespace ACE.Network.Messages
{
    /// <summary>
    /// Abandons a contract
    /// </summary>
    public abstract class Message : IPackable
    {
        public MessageType MessageType { get; } 
        public string MessageTypeNum
        {
            get { return string.Format("0x{0:X}", (ushort)MessageType); }
        }
        public MessageDirection MessageDirection { get; }
        public bool MessageOrdered { get; }
        public Queues MessageQueue { get; }

#if NETWORKVALIDATION
        public byte[] RawBytes { get; private set; }
        public int ByteLength { get { return RawBytes.Length; } }
#endif
#if NETWORKDEBUG
        public List<ulong> NetworkPacketNums { get; } = new List<ulong>();
        public string NetworkPackets
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var num in NetworkPacketNums)
                {
                    sb.Append(num);
                    sb.Append(" ");
                }
                return sb.ToString();
            }
        }
#endif

        public virtual void Unpack(BinaryReader reader)
        {
#if NETWORKVALIDATION
            var location = reader.BaseStream.Position;
            RawBytes = reader.ReadBytes((int)reader.BaseStream.Length);
            reader.BaseStream.Position = location;
#endif
        }

        public abstract void Pack(BinaryWriter writer);

        protected Message(MessageType type, MessageDirection direction, Queues queue, bool ordered = false)
        {
            MessageType = type;
            MessageDirection = direction;
            MessageQueue = queue;
            MessageOrdered = ordered;
        }

        private static OrderedHeader ReadWOrderHeader(BinaryReader reader)
        {
            uint objectId = reader.ReadUInt32();
            uint sequence = reader.ReadUInt32();
            return new OrderedHeader(objectId, sequence);
        }

        private static OrderedHeader ReadOrderHeader(BinaryReader reader)
        {
            uint sequence = reader.ReadUInt32();
            return new OrderedHeader(sequence);
        }

        public static Message ReadS2CMessage(BinaryReader reader)
        {
            return ReadMessage(reader, MessageFactory.ReadS2CMessage);
        }

        public static Message ReadC2SMessage(BinaryReader reader)
        {
            return ReadMessage(reader, MessageFactory.ReadC2SMessage);
        }

        public static Message ReadMessage(BinaryReader reader, Func<uint, BinaryReader, Message> func)
        {
            MessageType type = (MessageType)reader.ReadUInt32();
            Message message = null;
            if (type == MessageType.Network_WOrderHdr)
            {
                var orderHeader = ReadWOrderHeader(reader);
                type = (MessageType)reader.ReadUInt32();
                var orderedMessage = (OrderedMessage)func((uint)type, reader);
                orderedMessage.OrderHeader = orderHeader;
                message = orderedMessage;
            }
            else if(type == MessageType.Network_OrderHdr)
            {
                var orderHeader = ReadOrderHeader(reader);
                type = (MessageType)reader.ReadUInt32();
                var orderedMessage = (OrderedMessage)func((uint)type, reader);
                orderedMessage.OrderHeader = orderHeader;
                message = orderedMessage;
            }
            else
            {
                message = func((uint)type, reader);
            }
            return message;
        }
    }
}

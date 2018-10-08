using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;
using log4net;

namespace ACE.Network.Packets
{
    public class BlobFrag
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static readonly ushort BlobFragHeaderSize = 16;
        public static readonly ushort MaxBlobFragSize = 464;

#if NETWORKDEBUG
        public ulong NetworkPacketNum { get; set; }
        public uint NetworkFragmentNum { get; set; }
#endif

        public ulong BlobSequenceId { get; private set; }

        private BlobFragSequence netBlobId;
        public BlobFragSequence NetBlobId
        {
            get
            {
                return netBlobId;
            }
            set
            {
                netBlobId = value;

                if (IsEphemeral)
                    BlobSequenceId = GetSequenceID(value.RawValue);
                else
                    BlobSequenceId = value.RawValue;
            }
        }

        /// <summary>
        /// The number of fragments that make up the full content.  Partial fragments will always be sent alone and will fill the entire packet, except for the tail fragment.  The tail fragment can be sent prior to the others if it will fit.
        /// </summary>
        public ushort NumFrags { get; set; }

        /// <summary>
        /// Size of bytes contained in this fragment, including this header
        /// </summary>
        public ushort BlobFragSize { get; private set; }

        /// <summary>
        /// The zero based index of this fragment.
        /// </summary>
        public ushort BlobNum { get; set; }

        /// <summary>
        /// Identifies the queue this message should go into.  Client (and seemingly Server too) maintains several different queues for processing messages.  The queues seem to roughly align with overall feature type.  Eg client maintains one for login, one for dat, one for 3d/world, and one for UI.
        /// </summary>
        public Queues QueueID { get; set; }

        private byte[] bytes;
        /// <summary>
        /// Bytes content for this fragment
        /// </summary>
        public byte[] Bytes
        {
            get
            {
                return bytes;
            }
            set
            {
                bytes = value;
                BlobFragSize = (ushort)(bytes.Length + BlobFragHeaderSize);
            }
        }

        public ushort DataSize => (ushort)(BlobFragSize - BlobFragHeaderSize);

        public bool IsEphemeral => NetBlobId.EventType.HasFlag(SequenceFlags.Ephemeral);

        public BlobFrag(BinaryReader reader)
        {
            log.DebugAssert(reader.BytesRemaining() >= 20);
            UnpackHeaders(reader);
            log.Assert(reader.BytesRemaining() >= DataSize, "Not enough bytes remaining");
            Bytes = reader.ReadBytes(DataSize);
            log.DebugFormat("Reading Frag. BlobId: {0}, NumFrags: {1}, BlobFragSize: {2}, BlobNum: {3}, QueueID: {4}", NetBlobId, NumFrags, BlobFragSize, BlobNum, QueueID);
        }

        public BlobFrag(byte[] bytes)
        {
            Bytes = bytes;
        }

        private void UnpackHeaders(BinaryReader reader)
        {
            NetBlobId = new BlobFragSequence(reader.ReadUInt64());
            NumFrags = reader.ReadUInt16();
            BlobFragSize = reader.ReadUInt16();
            BlobNum = reader.ReadUInt16();
            QueueID = (Queues)reader.ReadUInt16();
        }

        public void Pack(BinaryWriter writer)
        {
            log.DebugAssert(NetBlobId.RawValue != 0, "BlobId not set");
            log.DebugAssert(NumFrags > 0, "NumFrags not set");
            log.DebugAssert(BlobNum >= 0 && BlobNum < NumFrags, "BlobNum Invalid");
            log.DebugAssert(QueueID != 0, "QueueID not set");
            log.DebugAssert(Bytes.Length > 0, "Bytes is zero");
            writer.Write(NetBlobId.RawValue);
            writer.Write(NumFrags);
            writer.Write(BlobFragSize);
            writer.Write(BlobNum);
            writer.Write((ushort)QueueID);
            writer.Write(Bytes);
        }

        

        public static bool IsEphemeralFlagSet(ulong id)
        {
            return (id & 0x8000000000000000) != 0;
        }

        public static ulong GetOrderingType(ulong id)
        {
            return id & 0x1F00000000000000;
        }

        public static ulong GetSequenceID(ulong id)
        {
            return id & 0xFF0000FFFFFFFF;
        }

        public static ulong MakeNetBlobId(ulong eventType, ulong id)
        {
            ulong evt = eventType;
            if ((eventType & 0xFF00000000000000) != eventType)
                evt = 0;
            return id | evt;
        }
    }
}

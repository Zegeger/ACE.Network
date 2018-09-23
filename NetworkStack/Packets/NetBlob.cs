using ACE.Network.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ACE.Network.Extensions;
using log4net;

namespace ACE.Network.Packets
{
    /// <summary>
    /// Represents a network blob which is transmitted as one or more blob fragments
    /// </summary>
    public class NetBlob
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public enum AddResult
        {
            SuccessPartial,
            SuccessComplete,
            ErrorFragExists
        }

        ulong Id { get; }
        uint NumFrags { get; }
        ushort Sender { get; }
        Queues QueueId { get; } 

        BlobFrag[] Fragments;
        uint fragCount = 0;

        /// <summary>
        /// Whether the blob is complete with all fragments added
        /// </summary>
        public bool IsComplete
        {
            get
            {
                return fragCount == NumFrags;
            }
        }

#if NETWORKDEBUG
        /// <summary>
        /// List of network packet numbers which contributed to this NetBlob.  Used for diagnostics.
        /// </summary>
        public IEnumerable<ulong> NetworkPacketNums
        {
            get
            {
                List<ulong> nums = new List<ulong>();
                foreach (var frag in Fragments)
                {
                    nums.Add(frag.NetworkPacketNum);
                }
                return nums;
            }
        }
#endif

        /// <summary>
        /// Creates a new NetBlob using the provided BlobFrag as the first
        /// </summary>
        /// <param name="frag">BlobFrag to add initially to this NetBlob</param>
        public NetBlob(BlobFrag frag)
        {
            log.DebugFormat("New NetBlob for ID 0x{0:X4}, Number of Frags: {1}, Queue ID: {2}", frag.BlobSequenceId, frag.NumFrags, frag.QueueID);
            Id = frag.BlobSequenceId;
            NumFrags = frag.NumFrags;
            QueueId = frag.QueueID;
            Fragments = new BlobFrag[frag.NumFrags];
            AddFrag(frag);
        }

        /// <summary>
        /// Adds a new BlobFrag
        /// </summary>
        /// <param name="frag">BlobFrag to add</param>
        /// <returns>Result of the add operation, either indicating an error, Success but still partial, or Success and complete</returns>
        public AddResult AddFrag(BlobFrag frag)
        {
            log.DebugFormat("AddFrag for ID 0x{0:X4}, BlobNum: {1}", Id, frag.BlobNum);
            if (Fragments[frag.BlobNum] != null)
            {
                log.WarnFormat("AddFrag for ID 0x{0:X4}, ErrorFragExists", Id);
                return AddResult.ErrorFragExists;
            }
            Fragments[frag.BlobNum] = frag;
            fragCount++;
            if (IsComplete)
            {
                log.DebugFormat("AddFrag for ID 0x{0:X4}, SuccessComplete", Id);
                return AddResult.SuccessComplete;
            }
            else
            {
                log.DebugFormat("AddFrag for ID 0x{0:X4}, SuccessPartial", Id);
                return AddResult.SuccessPartial;
            }
        }

        /// <summary>
        /// Returns the completed byte data accumulated in this NetBlob
        /// </summary>
        /// <returns></returns>
        public byte[] GetCompletedData()
        {
            log.DebugFormat("GetCompletedData for ID 0x{0:X4}", Id);
            log.DebugAssert(IsComplete, "Getting Data when NetBlob is not complete!");
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    foreach (BlobFrag frag in Fragments)
                    {
                        writer.Write(frag.Bytes);
                    }
                }
                return stream.ToArray();
            }
        }
    }
}

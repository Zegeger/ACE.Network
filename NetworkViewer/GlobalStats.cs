using ACE.Network.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools
{
    /// <summary>
    /// Tracks global statistics across the app run.
    /// </summary>
    public static class GlobalStats
    {
        public static long FileCount { get; set; }
        public static long PacketCount { get; set; }
        public static long MessageCount { get; set; }
        public static TimeSpan LoadTime { get; set; }
        public static Dictionary<MessageType, uint> MessageTypeCounter { get; set; } = new Dictionary<MessageType, uint>();

        static GlobalStats()
        {
            var values = Enum.GetValues(typeof(MessageType)).Cast<MessageType>();
            foreach (var e in values)
            {
                MessageTypeCounter.Add(e, 0);
            }
        }
    }
}

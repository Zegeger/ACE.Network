using ACE.Network.Messages;
using ACE.Network.Tools.NetworkViewer.Parsers;
using ACE.Network.Tools.NetworkViewer.Protocols;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ACE.Network.Tools
{
    /// <summary>
    /// Stores information regarding a single network trace.  Used in UI in the network trace list.
    /// </summary>
    class NetworkTrace : IDisposable
    {
        /// <summary>
        /// Path of network trace loaded
        /// </summary>
        public FileInfo FilePath { get; }

        /// <summary>
        /// File name of network trace loaded.
        /// Used in UI List.
        /// </summary>
        public string FileName
        {
            get
            {
                return FilePath.Name;
            }
        }

        /// <summary>
        /// String indicating whether errors occured when loading.
        /// Used in UI List.
        /// </summary>
        public string Error
        {
            get
            {
                if (exceptions.Count > 0)
                    return "Yes";
                return "";
            }
        }

        /// <summary>
        /// Boolean indicating whether errors occured when loading
        /// </summary>
        public bool HasError
        {
            get
            {
                if (exceptions.Count > 0)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// String exposing first 5 exceptions that occured when loading the trace.
        /// Pulled when viewing Errors option in context menu in UI
        /// </summary>
        public string Exceptions
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Number of Exceptions: " + exceptions.Count);
                int count = 0;
                foreach(var ex in exceptions)
                {
                    sb.AppendLine(ex.ToString());
                    if (++count > 5)
                        break;
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Current number of messages loaded from this file.
        /// </summary>
        public int Count
        {
            get
            {
                return Messages.Count;
            }
        }

        /// <summary>
        /// List of all messages loaded from this network trace.
        /// </summary>
        public List<Message> Messages { get; } = new List<Message>();

        /// <summary>
        /// List of messages meeting filter from this network trace.
        /// </summary>
        public List<Message> FilteredMessages { get; } = new List<Message>();

        /// <summary>
        /// Event raised when the FilteredMessages list has changed
        /// </summary>
        public event EventHandler FilteredMessagesChanged;


        /// <summary>
        /// List containing all exceptions occuring while loading the network trace.
        /// </summary>
        private List<Exception> exceptions = new List<Exception>();

        /// <summary>
        /// Lock for modifying FilteredMessages property
        /// </summary>
        private object messageLock = new object();

        /// <summary>
        /// Message filter class to use when filtering. Passed in constructor.
        /// </summary>
        private MessageFilter filter;

        // Port range to limit our network packets to.
        uint serverPortStart = 9000;
        uint serverPortEnd = 9010;

        // Stats
        Stopwatch parseFileSW = new Stopwatch();
        int recordCount = 0;

        // Defragmenter classes for inbound and outbound paths.  Does all the work extracting messages from packets.  Completed messages are raised in an event from these objects.
        Defragmenter c2sDefragmenter = new Defragmenter(MessageDirection.ClientToServer);
        Defragmenter s2cDefragmenter = new Defragmenter(MessageDirection.ServerToClient);

        public NetworkTrace(string fileName, MessageFilter filter)
        {
            FilePath = new FileInfo(fileName);
            this.filter = filter;
            this.filter.FilterChanged += Filter_FilterChanged;
            c2sDefragmenter.NewMessage += Defragmenter_NewMessage;
            s2cDefragmenter.NewMessage += Defragmenter_NewMessage;
            Load();
            GlobalStats.FileCount++;
            GlobalStats.PacketCount += recordCount;
            GlobalStats.MessageCount += Messages.Count;
        }

        /// <summary>
        /// Event raised when filter changes, allowing us to update our filtered messages list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filter_FilterChanged(object sender, EventArgs e)
        {
            FilteredMessages.Clear();
            lock (messageLock)
            {
                foreach (var message in Messages)
                {
                    AddFilteredMessage(message);
                }
            }
            FilteredMessagesChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Performs all the work loading a network trace. Exceptions are caught and added to the exceptions list.
        /// </summary>
        private void Load()
        {
            try
            {
                var parser = new NetworkFileParser(FilePath.FullName);
                parser.PacketRead += Parser_PacketRead;
                parseFileSW.Start();
                parser.Parse();
                parseFileSW.Stop();
            }
            catch (Exception ex)
            {
                exceptions.Add(ex);
            }
        }

        /// <summary>
        /// Event raised when a network packet is read from the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Parser_PacketRead(object sender, PacketReadEventArgs e)
        {
            var packet = e.PacketRecord;
            recordCount++;
            try
            {
                var etherPacket = packet.EthernetPacket;
                if (etherPacket != null && etherPacket.Proto == EtherType.IPv4)
                {
                    var ipPacket = etherPacket.Data as IPv4Packet;

                    // Ignore loopback traffic. We can't distinguish direction if both sides are local.
                    // TODO create a more complex algoritm that allows this, but uses port instead.  Would require client to not use server port range though.
                    if (ipPacket.SrcAddr.IsLocal && ipPacket.DestAddr.IsLocal)
                        return;

                    if (ipPacket != null && ipPacket.Proto == IPProtocolType.UDP)
                    {
                        var udpPacket = ipPacket.Data as UdpPacket;

                        // Only process udp packets inwhich one direction is within our server port range
                        if (
                            udpPacket != null &&
                            ((udpPacket.SrcPort >= serverPortStart && udpPacket.SrcPort <= serverPortEnd) ||
                            (udpPacket.DestPort >= serverPortStart && udpPacket.DestPort <= serverPortEnd))
                           )
                        {
                            var sourceIP = new System.Net.IPEndPoint(ipPacket.SrcAddr.LongAddress, udpPacket.SrcPort);
                            // Create an Packet using byte data.  Packet parses AC headers and fragments from the data.
#if NETWORKDEBUG
                            // Packet number for reference in UI
                            var ACPacket = new Packets.Packet(udpPacket.Data, sourceIP, packet.PacketNum);
#else
                            var ACPacket = new Packets.Packet(udpPacket.Data, sourceIP);
#endif
                            // Pass packet to defragmenter to extract messages
                            if (ipPacket.SrcAddr.IsLocal)
                                c2sDefragmenter.ProcessPacket(ACPacket);
                            else
                                s2cDefragmenter.ProcessPacket(ACPacket);
                        }
                    }
                }
            }
            catch (Exception ex2)
            {
                string error = "Exception at packet " + packet.PacketNum + " of file " + FilePath.FullName;
                var newEx = new Exception(error, ex2);
                exceptions.Add(newEx);
            }
        }

        /// <summary>
        /// Event raised when a new message is completed from the defragmenter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Defragmenter_NewMessage(object sender, NewMessageEventArgs e)
        {
            if(GlobalStats.MessageTypeCounter.ContainsKey(e.Message.MessageType))
                GlobalStats.MessageTypeCounter[e.Message.MessageType]++;
            AddMessage(e.Message);
            AddFilteredMessage(e.Message);
        }

        /// <summary>
        /// Adds a new message to the Message list.
        /// </summary>
        /// <param name="m">Message to add</param>
        private void AddMessage(Message m)
        {
            // If option is enabled, only add if filter applies.
            if (Options.ApplyFilterOnLoad)
            {
                if (!filter.CheckMessage(m))
                    return;
            }
            Messages.Add(m);
        }

        /// <summary>
        /// Adds a new message to the FilteredMessages list.
        /// </summary>
        /// <param name="m">Message to add</param>
        private void AddFilteredMessage(Message m)
        {
            if (filter.CheckMessage(m))
            {
                lock (messageLock)
                {
                    FilteredMessages.Add(m);
                }
            }
        }

        /// <summary>
        /// Retrieves all stats for this NetworkTrace
        /// </summary>
        /// <returns>String with stat</returns>
        public string Stats()
        {
            float pps = recordCount / (parseFileSW.ElapsedMilliseconds / 1000f);
            StringBuilder output = new StringBuilder();
            output.AppendLine("Packets: " + recordCount);
            output.AppendLine("Parsed Trace Time: " + parseFileSW.Elapsed);
            output.AppendLine("Packets per Sec: " + pps);
            return output.ToString();
        }

        public override string ToString()
        {
            return FilePath.Name;
        }

        #region IDisposable Support
        // Dispose to clear out filter event handler which roots our object otherwise.
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    filter.FilterChanged -= Filter_FilterChanged;
                }

                Messages.Clear();
                FilteredMessages.Clear();
                c2sDefragmenter = null;
                s2cDefragmenter = null;

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}

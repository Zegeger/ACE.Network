using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools
{
    /// <summary>
    /// Class to determine what traces to show based on their current filtered messages.  Traces with no messages to show are excluded.
    /// </summary>
    class TraceFilter
    {
        /// <summary>
        /// Current list of traces to show based on the filter results.
        /// </summary>
        public ObservableCollection<NetworkTrace> FilteredTraces { get; } = new ObservableCollection<NetworkTrace>();

        /// <summary>
        /// Source list of all traces
        /// </summary>
        private readonly ObservableCollection<NetworkTrace> traces;

        /// <summary>
        /// Event handler to raise when the FilteredTraces list changes.
        /// </summary>
        public event EventHandler FilteredTracesChanged;

        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="traces">Collection of traces to filter</param>
        public TraceFilter(ObservableCollection<NetworkTrace> traces)
        {
            this.traces = traces;
            traces.CollectionChanged += Traces_CollectionChanged;
            foreach(var item in traces)
            {
                item.FilteredMessagesChanged += Item_FilteredMessagesChanged;
                if (CheckTrace(item))
                    FilteredTraces.Add(item);
            }
        }

        /// <summary>
        /// Raised when a NetworkTrace's filtered message list changes allows us to check the new count and add or remove the item based on it.
        /// </summary>
        /// <param name="sender">NetworkTrace which sent the event</param>
        /// <param name="e">Event arguments</param>
        private void Item_FilteredMessagesChanged(object sender, EventArgs e)
        {
            NetworkTrace trace = (NetworkTrace)sender;
            bool isPresent = FilteredTraces.Contains(trace);
            bool include = CheckTrace(trace);
            if (isPresent && !include)
                FilteredTraces.Remove(trace);
            else if (!isPresent && include)
                FilteredTraces.Add(trace);
        }

        /// <summary>
        /// Event raised when the source collection changes, which would occur as new files are opened or subsequently removed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Traces_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                foreach(NetworkTrace item in e.NewItems)
                {
                    item.FilteredMessagesChanged += Item_FilteredMessagesChanged;
                    if (CheckTrace(item))
                        FilteredTraces.Add(item);
                }
            }
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                foreach(NetworkTrace item in e.OldItems)
                {
                    item.FilteredMessagesChanged -= Item_FilteredMessagesChanged;
                    if (FilteredTraces.Contains(item))
                        FilteredTraces.Remove(item);
                }
            }
            FilteredTracesChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Checks a Network Trace to determine if it has any messages to show.
        /// </summary>
        /// <param name="trace">Network trace to check</param>
        /// <returns>True if the NetworkTrace has messages to show</returns>
        public bool CheckTrace(NetworkTrace trace)
        {
            if (trace.FilteredMessages.Count > 0)
                return true;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using System.Diagnostics;

namespace ACE.Network.Tools
{
    /// <summary>
    /// Uses multiple threads to load network trace files.
    /// Files paths to open are queued.  Once opened the NetworkTrace object is placed into an ObservableCollection for use by the UI.
    /// 
    /// </summary>
    class FileLoader
    {
        // Dispatcher for calls to the UI Thread
        Dispatcher dispatcher;

        // File paths to open
        Queue<string> fileQueue = new Queue<string>();

        // Worker threads
        List<Thread> openThreads = new List<Thread>();

        // Number of open threads in progress.  Used to verify when open folder operations are complete for statistic purposes.
        int inProgress = 0;

        // Stopwatch tracking time spent opening files.
        Stopwatch loadSW = new Stopwatch();

        // Temporary list for completed traces.  They are copied to NetworkTraces by flushTimer to syncronize the operations to the UI thread.  Operations on traces are syncronized by traceSync.
        List<NetworkTrace> traces = new List<NetworkTrace>();
        Timer flushTimer;
        object traceSync = new object();

        // Reset event to alert when new files to load are added.  Unblocks worker threads.
        ManualResetEvent filesToLoad = new ManualResetEvent(false);

        // Boolean to indicate whether we are shutting down.  Used to terminate worker threads gracefully.
        bool shutdown = false;
        
        /// <summary>
        /// All opened network traces.
        /// </summary>
        public ObservableCollection<NetworkTrace> NetworkTraces { get; } = new ObservableCollection<NetworkTrace>();

        /// <summary>
        /// Handles filtering of messages within the NetworkTraces.  Passed into each NetworkTraces and shared amongst them.
        /// </summary>
        public MessageFilter Filter { get; } = new MessageFilter();

        /// <summary>
        /// Status message to display in UI
        /// </summary>
        public string StatusText { get; private set; }
        /// <summary>
        /// Maximum progress value for progress bar
        /// </summary>
        public int MaxProgress { get; private set; }

        private int currentProgress;

        /// <summary>
        /// Current progress value for progress bar
        /// </summary>
        public int CurrentProgress
        {
            get { return currentProgress; }
        }

        internal FileLoader(int threads, Dispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
            for (int i = 0; i <= threads; i++)
            {
                var thread = new Thread(OpenFolderWorker);
                thread.IsBackground = true;
                openThreads.Add(thread);
                thread.Start();
            }
            flushTimer = new Timer(FlushTick);
            flushTimer.Change(100, 100);
        }

        /// <summary>
        /// Terminates file loader, shutting down worker threads
        /// </summary>
        public void Shutdown()
        {
            shutdown = true;
            filesToLoad.Set();
            flushTimer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        /// <summary>
        /// Adds a single file to the queue to be opened
        /// </summary>
        /// <param name="path">Full path to file to be opened</param>
        public void AddFile(string path)
        {
            currentProgress = 0;
            MaxProgress = 1;
            AddFileInternal(path);
        }

        /// <summary>
        /// Adds all network traces located within the provided path, searching subfolders as well.
        /// </summary>
        /// <param name="path">Folder path to search for network traces</param>
        /// <returns>Number of files found</returns>
        public int AddFolder(DirectoryInfo path)
        {
            currentProgress = 0;
            MaxProgress = GetFiles(path);
            return MaxProgress;
        }

        /// <summary>
        /// Timer used to move completed network traces over to the public property.  Since NetworkTraces can be used by UI objects, this is done using dispatcher.
        /// </summary>
        /// <param name="state"></param>
        private void FlushTick(object state)
        {
            if (traces.Count > 0)
            {
                List<NetworkTrace> tempList;
                lock (traceSync)
                {
                    tempList = traces;
                    traces = new List<NetworkTrace>();
                }
                dispatcher.Invoke(() =>
                {
                    foreach (var item in tempList)
                    {
                        NetworkTraces.Add(item);
                    }
                });
            }
        }

        /// <summary>
        /// Adds single file to queue. Unblocks worker threads to start work.
        /// </summary>
        /// <param name="path"></param>
        private void AddFileInternal(string path)
        {
            lock (fileQueue)
            {
                fileQueue.Enqueue(path);
                if(!loadSW.IsRunning)
                    loadSW.Start();
                filesToLoad.Set();
            }
        }

        /// <summary>
        /// Worker thread which waits for new files to open and opens them. Once opened it is added to the traces list to eventually be moved over to the public list.
        /// </summary>
        private void OpenFolderWorker()
        {
            while (!shutdown)
            {
                filesToLoad.WaitOne();
                if (shutdown)
                    return;
                string file = null;
                lock (fileQueue)
                {
                    if (fileQueue.Count > 0)
                    {
                        file = fileQueue.Dequeue();
                    }
                }
                if (file != null)
                {
                    Interlocked.Increment(ref inProgress);
                    OpenFile(file);
                    Interlocked.Decrement(ref inProgress);
                }
                lock (fileQueue)
                {
                    if (fileQueue.Count == 0)
                    {
                        filesToLoad.Reset();

                        if (inProgress == 0)
                        {
                            loadSW.Stop();
                            GlobalStats.LoadTime += loadSW.Elapsed;
                            loadSW.Reset();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Locates all pcap files within the folder and subfolders.
        /// </summary>
        /// <param name="folder">Folder to search for network traces</param>
        /// <returns>Total count of files found</returns>
        private int GetFiles(DirectoryInfo folder)
        {
            int count = 0;
            foreach (var pcap in folder.GetFiles("*.pcap"))
            {
                AddFileInternal(pcap.FullName);
                count++;
            }
            foreach (var child in folder.GetDirectories())
            {
                count += GetFiles(child);
            }
            return count;
        }

        /// <summary>
        /// Opens a file by creating a new NetworkTrace object using provided path.
        /// </summary>
        /// <param name="file">File path to open</param>
        private void OpenFile(string file)
        {
            SetStatusText("Processing " + file);
            try
            {
                NetworkTrace newTrace = new NetworkTrace(file, Filter);
                if (!shutdown && newTrace != null && (!Options.ErrorOnly || newTrace.HasError))
                {
                    lock (traceSync)
                    {
                        traces.Add(newTrace);
                    }
                }
                else
                {
                    // If we're not going to keep the trace, Dispose it.  This cleans up event handlers that rooted the object.
                    newTrace.Dispose();
                }
            }
            finally
            {
                // Regardless of success or failure, increment our progress and output a new status message.
                Interlocked.Increment(ref currentProgress);
                SetStatusText("Processed " + file);
            }
        }

        /// <summary>
        /// Sets the current status text
        /// </summary>
        /// <param name="message">New message to set as the status message</param>
        private void SetStatusText(string message)
        {
            StatusText = String.Format("({0}/{1}) {2}", CurrentProgress, MaxProgress, message);
        }
    }
}

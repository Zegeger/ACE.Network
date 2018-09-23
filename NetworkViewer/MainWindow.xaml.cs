using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Input;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using ACE.Network.Messages;
using System.Threading;
using System.Collections;
using System.Globalization;

namespace ACE.Network.Tools.NetworkViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileLoader fileLoader;

        TraceFilter traceFilter;

        Timer statusUpdate;

        public MainWindow()
        {
            InitializeComponent();
            var threads = Environment.ProcessorCount > 2 ? 2 : 1;
            fileLoader = new FileLoader((int)threads, Dispatcher);
            traceFilter = new TraceFilter(fileLoader.NetworkTraces);
            statusUpdate = new Timer(TimerTick);
            statusUpdate.Change(100, 100);
            FileView.DataContext = traceFilter.FilteredTraces;
        }

        private void TimerTick(object state)
        {
            try
            {
                Dispatcher.Invoke(() =>
                {
                    StatusProgress.Maximum = fileLoader.MaxProgress;
                    StatusProgress.Value = fileLoader.CurrentProgress;
                    StatusText.Text = fileLoader.StatusText;

                    if(FileView.Items.Count > 0 && FileView.SelectedItem == null)
                    {
                        FileView.SelectedItem = FileView.Items[0];
                    }
                });
            }
            catch(TaskCanceledException)
            { }
        }

        #region File Menu Events
        private void OpenMenu_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            var result = ofd.ShowDialog();
            if(result.HasValue && result.Value)
            {
                var name = ofd.FileName;
                fileLoader.AddFile(name);
            }
        }

        private void OpenFolderMenu_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ValidateNames = false;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.FileName = "Folder Selection";
            var result = ofd.ShowDialog();
            if(result.HasValue && result.Value)
            {
                string folderPath = System.IO.Path.GetDirectoryName(ofd.FileName);
                var baseDir = new DirectoryInfo(folderPath);
                fileLoader.AddFolder(baseDir);
            }
        }

        private void StatsMenu_Click(object sender, RoutedEventArgs e)
        {
            double pps = GlobalStats.PacketCount / (GlobalStats.LoadTime.TotalMilliseconds / 1000);
            StringBuilder output = new StringBuilder();
            output.AppendLine("Files: " + GlobalStats.FileCount);
            output.AppendLine("Packets: " + GlobalStats.PacketCount);
            output.AppendLine("Parsed Trace Time: " + GlobalStats.LoadTime);
            output.AppendLine("Packets per Sec: " + pps);
            output.AppendLine("Messages: " + GlobalStats.MessageCount);
            output.AppendLine("Message Type Counts");
            foreach (var item in GlobalStats.MessageTypeCounter)
            {
                output.AppendLine(String.Format("   {1} : 0x{2:X}/{0}", item.Key, item.Value, (int)item.Key));
            }
            TextDetails td = new TextDetails("Global Stats", output.ToString());
            td.Show();
        }

        private void QuitMenu_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion
        #region Option Menu Events
        private void ErrorOnlyMenu_Click(object sender, RoutedEventArgs e)
        {
            Options.ErrorOnly = ErrorOnlyMenu.IsChecked;
        }

        private void ApplyFilterOnLoad_Click(object sender, RoutedEventArgs e)
        {
            Options.ApplyFilterOnLoad = ApplyFilterOnLoad.IsChecked;
        }

        #endregion
        #region File List Context Menu Events
        private void StatsDetailsMenu_Click(object sender, RoutedEventArgs e)
        {
            NetworkTrace trace = FileView.SelectedItem as NetworkTrace;
            if (trace != null)
            {
                TextDetails td = new TextDetails(trace.FileName, trace.Stats());
                td.Show();
            }
        }

        private void ErrorDetailsMenu_Click(object sender, RoutedEventArgs e)
        {
            NetworkTrace trace = FileView.SelectedItem as NetworkTrace;
            if (trace != null)
            {
                TextDetails td = new TextDetails(trace.FileName, trace.Exceptions);
                td.Show();
            }
        }
        #endregion
        #region Window Events
        private void FileView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateMessageList();
        }

        private void MessageView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DetailView.Items.Clear();
            var item = MessageView.SelectedItem as MessageViewItem;
            if (item != null)
            {
                var msg = item.Message;
                var root = CreateTreeViewItem(msg.MessageType.ToString());
                WalkProps(root, msg);
                DetailView.Items.Add(root);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            statusUpdate.Change(Timeout.Infinite, Timeout.Infinite);
            fileLoader.Shutdown();
        }

        private void ApplyFilter_Click(object sender, RoutedEventArgs e)
        {
            ApplyFilters();
        }

        private void MessageTypeFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ApplyFilters();
                e.Handled = true;
            }
        }
        #endregion

        private void UpdateMessageList()
        {
            ObservableCollection<MessageViewItem> newView = new ObservableCollection<MessageViewItem>();
            foreach (NetworkTrace item in FileView.SelectedItems)
            {
                foreach (Message m in item.FilteredMessages)
                {
                    var mvi = new MessageViewItem(item.FileName, m);
                    newView.Add(mvi);
                }
            }
            MessageView.DataContext = newView;

            if (FileView.SelectedItems.Count == 1)
            {
                NetworkTrace trace = FileView.SelectedItems[0] as NetworkTrace;
                StatsDetails.IsEnabled = true;
                ErrorsDetails.IsEnabled = trace.HasError;
            }
            else
            {
                StatsDetails.IsEnabled = false;
                ErrorsDetails.IsEnabled = false;
            }
        }
        
        private void WalkProps(TreeViewItem item, object obj)
        {
            if (obj == null)
                return;
            foreach (var prop in obj.GetType().GetProperties())
            {
                if (prop.GetCustomAttributes(typeof(MessageProperty), false).Length > 0)
                {
                    var val = prop.GetValue(obj);
                    var newItem = CreateTreeViewItem();
                    newItem.Header = prop.Name + " = " + HandleObject(newItem, val, prop.PropertyType);
                    item.Items.Add(newItem);
                }
            }
        }

        private string HandleObject(TreeViewItem item, object obj, Type propertyType = null)
        {
            Type type = null;
            if (obj == null && propertyType == null)
            {
                return "null";
            }
            else if(obj == null)
            {
                type = propertyType;
            }
            else
            {
                type = obj.GetType();
            }
            
            if(type.Name == "String")
            {
                return "\"" + obj + "\"";
            }
            else if (type.IsPrimitive)
            {
                return obj.ToString();
            }
            else if (type.IsEnum)
            {
                return obj.ToString();
            }

            if (obj == null)
                return "null";

            if (type.GetInterfaces().Contains(typeof(IList)))
            {
                var list = (IList)obj;
                WalkList(item, list);
                return "List. Count = " + list.Count;
            }
            else if (type.GetInterfaces().Contains(typeof(IDictionary)))
            {
                var collection = (IDictionary)obj;
                WalkDictionary(item, collection);
                return "Dictionary. Count = " + collection.Count;
            }
            else if (type.IsClass)
            {
                WalkProps(item, obj);
                return type.Name;
            }
            return "<undefined>";
        }

        private void WalkDictionary(TreeViewItem item, IDictionary dict)
        {
            foreach (DictionaryEntry entry in dict)
            {
                var newItem = CreateTreeViewItem();
                newItem.Header = entry.Key + " = " + HandleObject(newItem, entry.Value);
                item.Items.Add(newItem);
            }
        }

        private void WalkList(TreeViewItem item, IList list)
        {
            int count = 0;
            foreach (var entry in list)
            {
                var newItem = CreateTreeViewItem();
                newItem.Header = "[" + count++ + "] = " + HandleObject(newItem, entry);
                item.Items.Add(newItem);
            }
        }

        private TreeViewItem CreateTreeViewItem(string header = "")
        {
            var newItem = new TreeViewItem();
            newItem.IsExpanded = true;
            newItem.Header = header;
            return newItem;
        }
        
        private void ApplyFilters()
        {
            string input = MessageTypeFilter.Text;
            input = input.Replace("0x", "");
            int val;
            if (int.TryParse(input, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out val))
            {
                fileLoader.Filter.MessageType = val;
                UpdateMessageList();
            }
        }       
    }
}

using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading;
using System.Windows;

namespace MiniLogger
{
    /// <summary>
    /// Interaction logic for LoggerWindow.xaml
    /// </summary>
    public partial class LoggerWindow : Window
    {
        private static ObservableCollection<Entry> _entries;

        /// <summary> 
        /// Rather use the ShowWindow() method
        /// </summary>
        public LoggerWindow()
        {
            InitializeComponent();

            LogEntryList.ItemsSource = Entries;
            LogEntryList.DataContext = this;
        }

        internal static ObservableCollection<Entry> Entries
        {
            get => _entries ?? (_entries = new ObservableCollection<Entry>());
            set => _entries = value;
        }

        /// <summary> 
        /// Opens a new LoggerWindow that shows the "Entries" List
        /// </summary>
        public static void ShowWindow()
        {
            var window = new LoggerWindow();
            window.Show();
        }

        /// <summary> 
        /// Adds a single line entry to the LoggerWindow 
        /// with the current time and the format "hh:mm:ss: line"
        /// <param name="line">the single line for the entry</param> 
        /// </summary>
        public static void AddEntry(string line)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            Entries.Add(new Entry(DateTime.Now.ToLongTimeString() + ": " + line));
        }

        /// <summary> 
        /// Adds an entry to the LoggerWindow 
        /// with the current time and the format "hh:mm:ss: category  |  description"
        /// <param name="category">the category for the entry</param> 
        /// <param name="description">the description for the entry</param> 
        /// </summary>
        public static void AddEntry(string category, string description)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            Entries.Add(new Entry(DateTime.Now.ToLongTimeString() + ": " + category + "  |  " + description));
        }
    }

    /// <summary> 
    /// Entry class
    /// </summary>
    internal class Entry
    {
        public Entry(string entryValue)
        {
            EntryValue = entryValue;
        }

        public string EntryValue { get; set; }
    }
}

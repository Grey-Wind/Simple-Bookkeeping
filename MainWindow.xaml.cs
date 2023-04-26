using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SimpleBookkeeping
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<BookkeepingEntry> bookkeepingEntries = new List<BookkeepingEntry>();

        public MainWindow()
        {
            InitializeComponent();
            ReadDataFromJson();
            dataGrid.ItemsSource = bookkeepingEntries;
        }

        private void OnAddClicked(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow();
            if (editWindow.ShowDialog() == true)
            {
                bookkeepingEntries.Add(editWindow.Entry);
                SaveDataToJson();
            }
        }

        private void OnDeleteClicked(object sender, RoutedEventArgs e)
        {
            BookkeepingEntry entry = dataGrid.SelectedItem as BookkeepingEntry;
            if (entry != null)
            {
                bookkeepingEntries.Remove(entry);
                SaveDataToJson();
            }
        }

        private void OnImportClicked(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string jsonString = File.ReadAllText(openFileDialog.FileName);
                try
                {
                    JArray jsonArray = JArray.Parse(jsonString);
                    bookkeepingEntries = jsonArray.ToObject<List<BookkeepingEntry>>();
                    dataGrid.ItemsSource = bookkeepingEntries;
                    SaveDataToJson();
                }
                catch (JsonReaderException ex)
                {
                    MessageBox.Show("Invalid JSON format: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void OnExportClicked(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(bookkeepingEntries, Formatting.Indented));
            }
        }

        private void SaveDataToJson()
        {
            string jsonString = JsonConvert.SerializeObject(bookkeepingEntries, Formatting.Indented);
            File.WriteAllText("bookkeeping.json", jsonString);
        }

        private void ReadDataFromJson()
        {
            if (File.Exists("bookkeeping.json"))
            {
                string jsonString = File.ReadAllText("bookkeeping.json");
                try
                {
                    JArray jsonArray = JArray.Parse(jsonString);
                    bookkeepingEntries = jsonArray.ToObject<List<BookkeepingEntry>>();
                }
                catch (JsonReaderException ex)
                {
                    MessageBox.Show("Invalid JSON format: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }

    public class BookkeepingEntry
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    }
}

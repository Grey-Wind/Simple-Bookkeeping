using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleBookkeeping
{
    /// <summary>
    /// EditWindow.xaml 的交互逻辑
    /// </summary>
    public partial class EditWindow : Window
    {
        public BookkeepingEntry Entry { get; private set; }

        public EditWindow()
        {
            InitializeComponent();
            Entry = new BookkeepingEntry();
            //Entry.Date = DateTime.Today;//这个只能获取年月日，没有时分秒
            Entry.Date = DateTime.Now;//年月日和时分秒都有
            DataContext = Entry;
        }

        private void OnOKClicked(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void OnCancelClicked(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}

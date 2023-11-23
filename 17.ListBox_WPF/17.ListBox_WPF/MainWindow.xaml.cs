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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _17.ListBox_WPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> listdata;
        public MainWindow()
        {
            InitializeComponent();
            listdata = new List<string>();
            for(int i = 0; i <6; i++)
            {
                listdata.Add(i.ToString());
            }
            cblist.ItemsSource = listdata;
            lstBox.ItemsSource = listdata;
        }
    }
}

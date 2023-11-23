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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _16.Combobox_WPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        List<food> listName;
        List<string> strListName;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //2 : load 1 list string vào Combobox
            strListName = new List<string> { "danh sách 1", "Danh sách 2", "danh sách 3" };
            cbbLstStr.ItemsSource = strListName;

            //3 :  load 1 list kiểu class vào Combobox
            listName = new List<food> {  new food() { Name = "Món 1", Price = "20000" },
                                         new food() { Name = "Món 2", Price = "30000" },
                                         new food() { Name = "Món 3", Price = "50000" }};
            cbb2.ItemsSource = listName;
            //cbb2.DisplayMemberPath = "Name";
            cbb2.SelectionChanged += Cbb2_SelectionChanged;
            //cbb2.SelectedValuePath = "Price";

            // 4: Load danh sách bảng màu vaof Combobox
            cbb3.ItemsSource = typeof(Colors).GetProperties();

            
        }

        private void Cbb2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(cbb2.SelectedValue.ToString());
        }
    }
    public class food
    {
        public string Name { get; set; }
        public string Price { get; set; }

    }
}

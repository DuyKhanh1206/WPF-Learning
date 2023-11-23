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

namespace _18._4_ListView_Filtering_WPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
 public partial class MainWindow : Window
    {
    public List<User> data;
    public bool IsSort;
        public MainWindow()
        {
            InitializeComponent();
            IsSort = false;
            data = new List<User>();
            data.Add(new User() { Stt = 2, Name = "Nguyễn Duy Khánh", Mail = "ngkhanh1206@gmail.com", Sex = SexType.Male });
            data.Add(new User() { Stt = 2, Name = "湯浅さん", Mail = "湯浅さん@gmail.com", Sex = SexType.Male });
            data.Add(new User() { Stt = 3, Name = "Nguyễn Duy Khánh", Mail = "湯浅さん@gmail.com", Sex = SexType.FeMale });
            data.Add(new User() { Stt = 9, Name = "湯浅さん", Mail = "ngkhanh1206@gmail.com", Sex = SexType.Male });

            lsvMain.ItemsSource = data;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvMain.ItemsSource);
            view.Filter = UserFilter;

        }
        private bool UserFilter(object item)
        {
            if (string.IsNullOrEmpty(txtSeach.Text))
            {
                return true;

            }
            else
            {
                return ((item as User).Name.IndexOf(txtSeach.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            }
        }

        private void txtSeach_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lsvMain.ItemsSource).Refresh();
        }

        /// <summary> Hiển thị và sắp xếp khi click vào tiêu đề </summary> 

    }
    public enum SexType { Male, FeMale };
public class User
{
    public int Stt { get; set; }
    public string Name { get; set; }
    public string Mail { get; set; }
    public SexType Sex { get; set; }
}
}

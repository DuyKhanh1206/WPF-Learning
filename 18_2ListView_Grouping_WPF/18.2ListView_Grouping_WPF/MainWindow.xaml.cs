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

namespace _18._2ListView_Grouping_WPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User> data;
        public MainWindow()
        {
            InitializeComponent();

            InitializeComponent();
            data = new List<User>();
            data.Add(new User() { Stt = 1, Name = "Nguyễn Duy Khánh", Mail = "ngkhanh1206@gmail.com" ,Sex = SexType.Male});
            data.Add(new User() { Stt = 2, Name = "湯浅さん", Mail = "湯浅さん@gmail.com", Sex = SexType.Male });
            data.Add(new User() { Stt = 3, Name = "Nguyễn Duy Khánh", Mail = "ngkhanh1206@gmail.com", Sex = SexType.FeMale });

            lsvMain.ItemsSource = data;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvMain.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            view.GroupDescriptions.Add(groupDescription);
        }
    }
    public enum SexType { Male, FeMale};
    public class User
    {
        public int Stt { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public SexType Sex { get; set; }
    }
}

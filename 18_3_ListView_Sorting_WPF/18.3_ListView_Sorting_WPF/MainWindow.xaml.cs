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

namespace _18._3_ListView_Sorting_WPF
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
            // hiển thị và sắp xếp theo Stt
            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvMain.ItemsSource);
            //view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Stt", System.ComponentModel.ListSortDirection.Ascending));

            // hiển thị và sắp xếp theo tên (Name) và (Mail)
            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvMain.ItemsSource);
            //view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Name", System.ComponentModel.ListSortDirection.Ascending));
            //view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Mail", System.ComponentModel.ListSortDirection.Ascending));
        }

        /// <summary> Hiển thị và sắp xếp khi click vào tiêu đề </summary> 
        private void GridViewColumnHeader_Click_2(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader header = sender as GridViewColumnHeader;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lsvMain.ItemsSource);

            //trước khi add và sxep mới thì cần phải xóa các trình tự cũ.
            if (IsSort)
            {
                //Chỉ remove cái list view để add lại chứ k xóa định dạng sắp xếp cũ
                //view.SortDescriptions.Remove(new System.ComponentModel.SortDescription(header.Content.ToString(), System.ComponentModel.ListSortDirection.Descending));

                //(Clear: xóa hết các properties kèm theo)
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription(header.Content.ToString(), System.ComponentModel.ListSortDirection.Ascending));
            }
            else
            {
                {
                    //view.SortDescriptions.Remove(new System.ComponentModel.SortDescription(header.Content.ToString(), System.ComponentModel.ListSortDirection.Ascending));
                    view.SortDescriptions.Clear();
                    view.SortDescriptions.Add(new System.ComponentModel.SortDescription(header.Content.ToString(), System.ComponentModel.ListSortDirection.Descending));
                }
            }
            IsSort = !IsSort;
           
        }
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

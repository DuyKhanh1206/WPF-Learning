using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _19.TreeView_WPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            #region vidu3
            MenuItem root = new MenuItem() { Title = "Menu" };
            MenuItem Children1 = new MenuItem() { Title = "Childrent 1" };
            Children1.Items.Add(new MenuItem() { Title = "child 1.1" });
            Children1.Items.Add(new MenuItem() { Title = "child 1.2" });
            root.Items.Add(Children1);
            root.Items.Add(new MenuItem() { Title = "Childrent 2" });

            MenuItem Children3 = new MenuItem() { Title = "Childrent 3" };
            // khai báo tree con của con  
            //Children3.Items.Add(new MenuItem() { Title = "child 3.1" });
            MenuItem chil3_1 = new MenuItem() { Title = "child 3.1" };
            chil3_1.Items.Add(new MenuItem() { Title = "3.1.1" });
            chil3_1.Items.Add(new MenuItem() { Title = "3.1.1" });
            Children3.Items.Add(chil3_1);

            Children3.Items.Add(new MenuItem() { Title = "child 3.2" });

            root.Items.Add(Children3);
            trvMain.Items.Add(root);
            #endregion

            #region ví dụ 4
            List<Family> familys = new List<Family>();

            Family family1 = new Family() { Name = "case 1" };
            family1.Member.Add(new FamilyMember() { Name = "tên số 1", Age = 15 });
            family1.Member.Add(new FamilyMember() { Name = "tên số 15", Age = 125 });
            family1.Member.Add(new FamilyMember() { Name = "tên số 18", Age = 145 });
            familys.Add(family1);

            Family family2 = new Family() { Name = "case 2" };
            family2.Member.Add(new FamilyMember() { Name = "tên số 2", Age = 215 });
            family2.Member.Add(new FamilyMember() { Name = "tên số 25", Age = 255 });
            family2.Member.Add(new FamilyMember() { Name = "tên số 28", Age = 245 });
            familys.Add(family2);
            trvFamily.ItemsSource = familys;



            #endregion
        }
    }
    /// <summary>dùng cho vidu3 </summary>
    public class MenuItem  // kiểu dữ liệu tham chiếu
    {
        public MenuItem()
        {
            this.Items = new ObservableCollection<MenuItem>();  // ObservableCollection đều là danh sách giống list
                                                                //  nhưng nó cập nhật cho giao diện cập nhật ngay lúc khi binding nhưng code sẽ chậm đi
        }
        public string Title { get; set; }
        public ObservableCollection<MenuItem> Items { get; set; }    // danh sách các note con

    }






    public class Family
    {
        public Family()
        {
            this.Member = new ObservableCollection<FamilyMember>();
        }
        public string Name { get; set; }
        public ObservableCollection<FamilyMember> Member { get; set; }
    }

    public class FamilyMember
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

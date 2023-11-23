using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace _23.Value_Converter_WPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class AgeConverter : IValueConverter
    {
        //Convert và trả về value
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime? SelectedDate = value as DateTime?;
            if (SelectedDate == null)
                return null;
            return SelectedDate.Value.Year;
        }

        //lấy value định dạng và trả về hiển thị
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int year = (int)value;
            return new DateTime(year, 1, 1);
        }
    }
}

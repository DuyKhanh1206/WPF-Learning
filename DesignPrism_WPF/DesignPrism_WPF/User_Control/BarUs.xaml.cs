using DesignPrism_WPF.ViewModels;
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

namespace DesignPrism_WPF.User_Control
{
    /// <summary>
    /// BarUs.xaml の相互作用ロジック
    /// </summary>
    public partial class BarUs : UserControl
    {
        public BarUsViewModel barUs_ViewModel { get; set; }
        public BarUs()
        {
            InitializeComponent();        
            this.DataContext = barUs_ViewModel = new BarUsViewModel();  
        }
    }
}

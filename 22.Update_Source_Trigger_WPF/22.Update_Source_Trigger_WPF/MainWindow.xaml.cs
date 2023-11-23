using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace _22.Update_Source_Trigger_WPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _dataValue;
        public string DataValue
        {
            get { return _dataValue; }
            set { _dataValue = value; OnPropertyChange("DataValue"); }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataValue = "change data";
            this.DataContext = this;
        }

       

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChange(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}

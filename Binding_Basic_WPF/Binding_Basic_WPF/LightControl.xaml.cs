using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Binding_Basic_WPF
{
    /// <summary>
    /// LightControl.xaml の相互作用ロジック
    /// </summary>
    public partial class LightControl : UserControl 
    {
        private bool IsRed;
        bool breg = true;
        public LightControl()
        {
            IsRed = false;
            InitializeComponent();
            
            while (breg)
            {
                if (!IsRed)
                {
                    IsRed = true;
                }
                IsRed = false;

                Thread.Sleep(5000);
            }
        }

      
    }
}

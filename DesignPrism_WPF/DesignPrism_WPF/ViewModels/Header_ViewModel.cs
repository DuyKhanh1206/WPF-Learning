using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrism_WPF.ViewModels
{
    public class Header_ViewModel:BindableBase
    {
        private string _dateText = System.DateTime.Now.ToString("yyyy/MM/dd");
        public string DateText { get { return _dateText; } set { SetProperty(ref _dateText, value); } }

        private string _clockText = System.DateTime.Now.ToString("HH:mm:ss");
        public string ClockText { get { return _clockText; } set { SetProperty(ref _clockText, value); } }
        public Header_ViewModel() { }
    }
}

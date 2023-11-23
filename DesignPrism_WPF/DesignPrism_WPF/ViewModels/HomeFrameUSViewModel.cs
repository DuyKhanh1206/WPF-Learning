using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrism_WPF.ViewModels
{
    public class HomeFrameUSViewModel:BindableBase
    {
        private string _title;
        public string Title { get { return _title; } set { if (_title != value) { _title = value; SetProperty( ref _title, value); } } }

      public HomeFrameUSViewModel()
      {

      }
    }
}

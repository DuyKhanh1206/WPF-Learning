using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Prism.Mvvm;
using Prism.Commands;

namespace DesignPrism_WPF.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        public DelegateCommand<Window> LoginCommand { get; set; }
        public bool IsLogin { get; set; }
      
        public LoginViewModel()
        {
            IsLogin = false;
            LoginCommand = new DelegateCommand<Window>((p) => { Login(p); });
        }
        void Login(Window p)
        {
            if (p == null)
            {
                return;
            }
            IsLogin = true;
            p.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPrism_WPF.Views;
using DesignPrism_WPF;
using Prism.Mvvm;
using System.Windows;
using Prism.Commands;
using System.Windows.Controls;
using Prism.Regions;
using Prism.Services.Dialogs;
using DesignPrism_WPF.User_Control;

namespace DesignPrism_WPF.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private IRegionManager _regionManager;
        private IDialogService _dialogService;
        public DelegateCommand<Window> LoadCommand { get; }
        
        public MainWindowViewModel(IRegionManager regionManager, IDialogService dialogService) 
        {
            _regionManager = regionManager;
            LoadCommand = new DelegateCommand<Window>(LoadCommandExecute);                
        }

        private void LoadCommandExecute(Window window) 
        {

            if (window == null)
            {
                return;
            }
            window.Hide();
            Login login = new Login();
            login.ShowDialog();

            if (login.DataContext == null)
                return;
            var loginVm = login.DataContext as LoginViewModel;
            if (loginVm.IsLogin)
            {
               
                window.Show();
                _regionManager.RequestNavigate("ContentRegion", nameof(HomeFrameUs));
            }
            else
            {
                window.Close();
            }
        }
    }
}

using DesignPrism_WPF.User_Control;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace DesignPrism_WPF.ViewModels
{
    public class AllButtonUsViewModel:BindableBase
    {
        private IRegionManager _regionManager;
        private IDialogService _dialogService;
        public DelegateCommand StartCommand { get;  }
        public DelegateCommand PauseCommand { get;  }
        public DelegateCommand SettingScreenCommand { get; }
        public DelegateCommand SysTemCommand { get;  }
        
        public AllButtonUsViewModel(IRegionManager regionManager, IDialogService dialogService)        
        {
            _regionManager = regionManager;
            StartCommand = new DelegateCommand(StartCommandExecute);
            PauseCommand = new DelegateCommand(PauseCommandExecute);


        }


        private void StartCommandExecute()
        {
            _regionManager.RequestNavigate("ContentRegion", nameof(HomeFrameUs));
        }
        private void PauseCommandExecute()
        {
            _regionManager.RequestNavigate("ContentRegion", nameof(PauseUs));
        }
    }
}

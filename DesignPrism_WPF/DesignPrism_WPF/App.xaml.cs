using DesignPrism_WPF.ViewModels;
using DesignPrism_WPF.Views;
using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DesignPrism_WPF.User_Control;

namespace DesignPrism_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App: PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {   
           
            containerRegistry.RegisterForNavigation<HomeFrameUs, HomeFrameUSViewModel>();
            containerRegistry.RegisterForNavigation<PauseUs, PauseUsViewModel>();

          
            containerRegistry.RegisterSingleton<MainWindowViewModel>();
        }
    }
}

using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPrism_WPF.User_Control;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;

namespace DesignPrism_WPF.ViewModels
{
    public class BarUsViewModel:BindableBase
    {
        public DelegateCommand<UserControl> MinimizeWindowCommand { get;  }
        public DelegateCommand<UserControl> MaximizeWindowCommand { get; }
        public DelegateCommand<UserControl> CloseWindowCommand { get; }
        public DelegateCommand<UserControl> MouseMoveWindowCommand { get; }


        public BarUsViewModel()
        {
            CloseWindowCommand = new DelegateCommand<UserControl>( (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    w.Close();
                }
            });

            MaximizeWindowCommand = new DelegateCommand<UserControl>( (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    if (w.WindowState != WindowState.Maximized)
                    {
                        w.WindowState = WindowState.Maximized;
                    }
                    else
                    {
                        w.WindowState = WindowState.Normal;
                    }
                }
            });

            MinimizeWindowCommand = new DelegateCommand<UserControl>( (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    if (w.WindowState != WindowState.Minimized)
                    {
                        w.WindowState = WindowState.Minimized;
                    }
                    else
                    {
                        w.WindowState = WindowState.Maximized;
                    }
                }
            });

            MouseMoveWindowCommand = new DelegateCommand<UserControl>(MouseMoveWindowCommandExecute) ;
        }
      
        private void MouseMoveWindowCommandExecute(UserControl parameter)
        {
            FrameworkElement window = GetWindowParent(parameter);
            var w = window as Window;
            if (w != null)
            {
                w.DragMove();
            } }
    
        FrameworkElement GetWindowParent(UserControl p)
        {
            FrameworkElement parent = p;
            while (parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }
            return parent;
        }

    }
    
}

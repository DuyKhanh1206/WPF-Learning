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

namespace DesignPrism_WPF.Views
{
    /// <summary>
    /// UserControl1.xaml の相互作用ロジック
    /// </summary>
    public partial class AllButtonUs : UserControl
    {
        public AllButtonUs()
        {
            InitializeComponent();
        }

        private Button lastClickedButton;
        public void MouseLeftButtonDownHandler(object sender, MouseButtonEventArgs e)
        {
            Border border = (Border)sender;
            Button clickedButton = (Button)border.TemplatedParent;

            if (lastClickedButton != null && lastClickedButton != clickedButton)
            {
                ImageBrush imageBrush = new ImageBrush();
                imageBrush.ImageSource = new BitmapImage(new Uri("C:\\Users\\k-nguyen\\Documents\\Visual Studio 2015\\Projects\\yatteimasu\\Design_Start\\anh_cty.jpg"));
                lastClickedButton.Background = imageBrush;
            }

            ImageBrush clickedImageBrush = new ImageBrush();
            clickedImageBrush.ImageSource = new BitmapImage(new Uri("C:\\Users\\k-nguyen\\Documents\\Visual Studio 2015\\Projects\\yatteimasu\\Design_Start\\画面.jpg"));
            clickedButton.Background = clickedImageBrush;

            lastClickedButton = clickedButton;
        }
    }
}

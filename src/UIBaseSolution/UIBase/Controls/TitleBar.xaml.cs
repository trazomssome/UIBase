using CommunityToolkit.Mvvm.ComponentModel;
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
using WpfLIb.Extensions;

namespace UIBase.Controls
{
    /// <summary>
    /// TitleBar.xaml에 대한 상호 작용 논리
    /// </summary>
    [ObservableObject]
    public partial class TitleBar : UserControl
    {
        private Window? parentWindow;
        private WindowState winState;

        public WindowState WinState
        {
            get => winState;
            set => SetProperty(ref winState, value);
        }

        public Window ParentWindow
        {
            get
            {
                if (parentWindow == null)
                {
                    parentWindow = this.FindParent<Window>()!;
                }
                return parentWindow;
            }
            set => parentWindow = value;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            WinState = ParentWindow.WindowState;
        }

        public TitleBar()
        {
            InitializeComponent();

            btnExit.Click += BtnExit_Click;
            btnMaximize.Click += BtnMaximize_Click;
            btnMinimize.Click += BtnMinimize_Click;
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WinState = WindowState.Minimized;
            ParentWindow.WindowState = WinState;
        }

        private void BtnMaximize_Click(object sender, RoutedEventArgs e)
        {
            WinState = WinState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
            ParentWindow.WindowState = WinState;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.Close();
        }
    }
}

using GalaSoft.MvvmLight.Ioc;
using MaterialDesignThemes.Wpf;
using MvvmlightWpfApp.Common;
using MvvmlightWpfApp.Controls;
using MvvmlightWpfApp.Messengers;
using MvvmlightWpfApp.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MvvmlightWpfApp.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            SimpleIoc.Default.GetInstance<IWindowService>().RegisterWindowIntPtr(this, NotificationsToken.MainViewWindowIntPtr);
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);
 
            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }
    }
}

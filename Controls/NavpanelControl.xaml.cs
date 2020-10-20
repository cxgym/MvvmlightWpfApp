using GalaSoft.MvvmLight.Ioc;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmlightWpfApp.Controls
{
    /// <summary>
    /// NavpanelControl.xaml 的交互逻辑
    /// </summary>
    public partial class NavpanelControl : UserControl
    {
        public NavpanelControl()
        {
            InitializeComponent();
            SimpleIoc.Default.GetInstance<IWindowService>().RegisterWindowIntPtr(this, NotificationsToken.NavpanelControlWindowIntPtr);
        }
    }
}

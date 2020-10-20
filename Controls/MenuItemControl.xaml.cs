using GalaSoft.MvvmLight.Ioc;
using MvvmlightWpfApp.Common;
using MvvmlightWpfApp.Messengers;
using MvvmlightWpfApp.Services.Impl;
using MvvmlightWpfApp.Views;
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

namespace MvvmlightWpfApp.Controls
{
    /// <summary>
    /// MenuItemControl.xaml 的交互逻辑
    /// </summary>
    public partial class MenuItemControl : UserControl
    {
        public MenuItemControl()
        {
            InitializeComponent();
        }

        public MenuItemControl(ItemMenu itemMenu)
        {
            InitializeComponent();
            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;
            this.DataContext = itemMenu;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
         {
            (SimpleIoc.Default.GetInstance<IWindowService>().GetWindowIntPtr(NotificationsToken.MainViewWindowIntPtr) as MainView).SwitchScreen(((SubItem)((ListView) sender).SelectedItem).Screen);
         }
    }
}

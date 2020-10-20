using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using MvvmlightWpfApp.Messengers;
using MvvmlightWpfApp.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MvvmlightWpfApp.ViewModel
{
    public class NavpanelControlModel : ViewModelBase
    {
        public ICurrentWindowService CurrentWindowService => SimpleIoc.Default.GetInstance<ICurrentWindowService>();

        public Window MainViewWindowIntPtr { get; set; }

        //public Window NavpanelControlWindowIntPtr { get; set; }

        private static int _maxOriginal;

        private Visibility isShowMaxButton;
        public Visibility IsShowMaxButton
        {
            get { return isShowMaxButton; }
            set { isShowMaxButton = value; RaisePropertyChanged(() => IsShowMaxButton); }
        }

        private Visibility isShowHuanyuanButton;
        public Visibility IsShowHuanyuanButton
        {
            get { return isShowHuanyuanButton; }
            set { isShowHuanyuanButton = value; RaisePropertyChanged(() => IsShowHuanyuanButton); }
        }

        #region  ICommand

        private RelayCommand<RoutedEventArgs> loadedCommand;
        public RelayCommand<RoutedEventArgs> LoadedCommand
        {
            get
            {
                if (loadedCommand == null)
                    loadedCommand = new RelayCommand<RoutedEventArgs>(e => ExcuteLoadedCommand(e));
                return loadedCommand;
            }
            set { loadedCommand = value; }
        }

        private RelayCommand<MouseButtonEventArgs> navpanel_MouseLeftButtonDownCommand;
        public RelayCommand<MouseButtonEventArgs> Navpanel_MouseLeftButtonDownCommand
        {
            get
            {
                if (navpanel_MouseLeftButtonDownCommand == null)
                    navpanel_MouseLeftButtonDownCommand = new RelayCommand<MouseButtonEventArgs>(e => Excute_Navpanel_MouseLeftButtonDownCommand(e));
                return navpanel_MouseLeftButtonDownCommand;
            }
            set { navpanel_MouseLeftButtonDownCommand = value; }
        }

        private RelayCommand<MouseButtonEventArgs> navpanel_MouseDoubleClickCommand;
        public RelayCommand<MouseButtonEventArgs> Navpanel_MouseDoubleClickCommand
        {
            get
            {
                if (navpanel_MouseDoubleClickCommand == null)
                    navpanel_MouseDoubleClickCommand = new RelayCommand<MouseButtonEventArgs>(e => Excute_Navpanel_MouseDoubleClickCommand(e));
                return navpanel_MouseDoubleClickCommand;
            }
            set { navpanel_MouseDoubleClickCommand = value; }
        }

        private RelayCommand navButtonMinCommand;
        public RelayCommand NavButtonMinCommand
        {
            get
            {
                if (navButtonMinCommand == null)
                    navButtonMinCommand = new RelayCommand(() => ExcuteNavButtonMinCommand());
                return navButtonMinCommand;
            }
            set { navButtonMinCommand = value; }
        }

        private RelayCommand navButtonMaxCommand;
        public RelayCommand NavButtonMaxCommand
        {
            get
            {
                if (navButtonMaxCommand == null)
                    navButtonMaxCommand = new RelayCommand(() => ExcuteNavButtonMaxCommand());
                return navButtonMaxCommand;
            }
            set { navButtonMaxCommand = value; }
        }

        private RelayCommand navButtonCloseCommand;
        public RelayCommand NavButtonCloseCommand
        {
            get
            {
                if (navButtonCloseCommand == null)
                    navButtonCloseCommand = new RelayCommand(() => ExcuteNavButtonCloseCommand());
                return navButtonCloseCommand;
            }
            set { navButtonCloseCommand = value; }
        }

        #endregion       

        public NavpanelControlModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                IsShowMaxButton = Visibility.Visible;
                IsShowHuanyuanButton = Visibility.Collapsed;
            }
        }

        #region  Command

        private void ExcuteLoadedCommand(RoutedEventArgs e)
        {
            MainViewWindowIntPtr = SimpleIoc.Default.GetInstance<IWindowService>().GetWindowIntPtr(NotificationsToken.MainViewWindowIntPtr);
        }

        private void Excute_Navpanel_MouseLeftButtonDownCommand(MouseButtonEventArgs e)
        {
            //var source = e.Source as FrameworkElement;              
            MainViewWindowIntPtr.DragMove();
        }

        private void Excute_Navpanel_MouseDoubleClickCommand(MouseButtonEventArgs e)
        {          
            switch (MainViewWindowIntPtr.WindowState)
            {
                case WindowState.Normal:
                    MainViewWindowIntPtr.WindowState = WindowState.Maximized;
                    IsShowMaxButton = Visibility.Collapsed;
                    IsShowHuanyuanButton = Visibility.Visible;
                    _maxOriginal = 1;
                    break;
                case WindowState.Maximized:
                    MainViewWindowIntPtr.WindowState = WindowState.Normal;
                    IsShowMaxButton = Visibility.Visible;
                    IsShowHuanyuanButton = Visibility.Collapsed;
                    _maxOriginal = 0;
                    break;
            }
        }

        private void ExcuteNavButtonMinCommand()
        {
            MainViewWindowIntPtr.WindowState = WindowState.Minimized;
        }

        private void ExcuteNavButtonMaxCommand()
        {
            if (_maxOriginal == 0)
            {
                MainViewWindowIntPtr.WindowState = WindowState.Maximized;
                //(Application.Current.FindResource("NavButtonStyle") as Style)
                IsShowMaxButton = Visibility.Collapsed;
                IsShowHuanyuanButton = Visibility.Visible;               
                _maxOriginal = 1;
            }
            else
            {
                MainViewWindowIntPtr.WindowState = WindowState.Normal;
                IsShowMaxButton = Visibility.Visible;
                IsShowHuanyuanButton = Visibility.Collapsed;
                _maxOriginal = 0;
            }
        }

        private void ExcuteNavButtonCloseCommand()
        {
            CurrentWindowService.Exit();
        }

        #endregion

    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using MvvmlightWpfApp.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmlightWpfApp.ViewModel
{
    public class BottompanelControlModel : ViewModelBase
    {
        private bool _clockIsRunning;

        #region  DIProperty

        private string timer = "00:00:00";
        public string Timer
        {
            get { return timer; }
            set { timer = value; RaisePropertyChanged(() => Timer); }
        }

        #endregion

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

        private RelayCommand<RoutedEventArgs> unloadedCommand;
        public RelayCommand<RoutedEventArgs> UnloadedCommand
        {
            get
            {
                if (unloadedCommand == null)
                    unloadedCommand = new RelayCommand<RoutedEventArgs>(e => ExcuteUnloadedCommand(e));
                return unloadedCommand;
            }
            set { unloadedCommand = value; }
        }

        #endregion

        #region  Command

        /// <summary>
        /// IDispatcherHelper主要解决自定义的后台线程刷新UI线程
        /// </summary>
        /// <param name="e"></param>
        private void ExcuteLoadedCommand(RoutedEventArgs e)
        {
            _clockIsRunning = true;

            Task.Run(async () =>
            {
                while (_clockIsRunning)
                {
                    await Task.Delay(1000);

                    if (_clockIsRunning)
                    {
                        SimpleIoc.Default.GetInstance<IDispatcherHelper>()
                            .CheckBeginInvokeOnUi(() =>
                            {
                                var now = DateTime.Now;
                                Timer = $"{now.Hour:D2}:{now.Minute:D2}:{now.Second:D2}";
                            });
                    }
                }
            });
        }

        private void ExcuteUnloadedCommand(RoutedEventArgs e)
        {
            _clockIsRunning = false;
        }

        #endregion

    }
}

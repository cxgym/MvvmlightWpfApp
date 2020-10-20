using GalaSoft.MvvmLight.platform.Threading;
using MvvmlightWpfApp.ViewModel;
using MvvmlightWpfApp.Views;
using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Threading;

namespace MvvmlightWpfApp
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            logger.Info("OnAppStartup");
            logger.Info($"args: {string.Join(" ", e.Args)}");
            DispatcherUnhandledException += App_DispatcherUnhandledException;
            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            DispatcherHelper.Initialize();

            var loginview = new LoginView();
            loginview.ShowDialog();
            if (loginview.DataContext is LoginViewModel loginViewModel)
            {
                if (loginViewModel.DialogResult)
                {
                    ShowMainWindow();
                }
            }
            
            //初始化配置信息
            //AppSettings.LoginName = "chenxin";
            //AppSettings.Password = "123456";
            //AppSettings.AllowSavePwd = true;
            //AppSettings.AppFlag = 1;
            //将初始化配置信息保存在上下文AppContext对象中
            //AppContext.LoginName = AppSettings.LoginName;
            //AppContext.Password = AppSettings.Password;
            //AppContext.AllowSavePwd = AppSettings.AllowSavePwd;
            //AppContext.AppFlag = AppSettings.AppFlag;
        }

        private void ShowMainWindow()
        {
            var mainview = new MainView();
            Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            Current.MainWindow = mainview;
            mainview.Show();
        }

        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            logger.Error(e.Exception);
            return;
        }

        private void App_OnExit(object sender, ExitEventArgs e)
        {
            logger.Info("OnAppExit");
            ViewModelLocator.Cleanup();
        }
    }
}
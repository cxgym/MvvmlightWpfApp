using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using MvvmlightWpfApp.Behaviors;
using MvvmlightWpfApp.Entity.Fysite;
using MvvmlightWpfApp.Messengers;
using MvvmlightWpfApp.Services.Impl;
using System;
using System.Diagnostics;
using System.Windows;

namespace MvvmlightWpfApp.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public ShutdownWindowAnimateBehavior ShutdownWindowAnimateBehaviorService => ShutdownWindowAnimateBehavior.GetInstance();
        public ICurrentWindowService CurrentWindowService => SimpleIoc.Default.GetInstance<ICurrentWindowService>();

        #region  DIProperty

        private string loginErrorMsg;
        public string LoginErrorMsg
        {
            get { return loginErrorMsg; }
            set { loginErrorMsg = value; RaisePropertyChanged(() => LoginErrorMsg); }
        }

        private SYS_USER sys_user;
        public SYS_USER SYS_USER
        {
            get { return sys_user; }
            set { sys_user = value; RaisePropertyChanged(() => SYS_USER); }
        }

        private bool dialogResult;
        public bool DialogResult
        {
            get { return dialogResult; }
            set { dialogResult = value; RaisePropertyChanged(() => DialogResult); }
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

        private RelayCommand loginClickCommand;
        public RelayCommand LoginClickCommand
        {
            get
            {
                if (loginClickCommand == null)
                    loginClickCommand = new RelayCommand(() => ExcuteLoginClickCommand(), CanExcuteLoginClickCommand);
                return loginClickCommand;
            }
            set { loginClickCommand = value; }
        }

        private RelayCommand<SYS_USER> cancelClickCommand;
        public RelayCommand<SYS_USER> CancelClickCommand
        {
            get
            {
                if (cancelClickCommand == null)
                    cancelClickCommand = new RelayCommand<SYS_USER>(e => ExcuteCancelClickCommand(e));
                return cancelClickCommand;
            }
            set { cancelClickCommand = value; }
        }

        #endregion

        #region  Init

        public LoginViewModel()
        {
            SYS_USER = new SYS_USER();

            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                //注销当前页面对象所有的注册消息
                Messenger.Default.Unregister(this);
                //message为参数值、lamdba表达式为执行消息体函数
                Messenger.Default.Register<PropertyChangedMessage<string>>(this, message =>
                {
                    //if (message.PropertyName == nameof(SYS_USER.PASSWORD_PropertyChanged))
                    //{
                    //    LoginErrorMsg = $"PASSWORD旧值{message.OldValue}-->新值{message.NewValue}";
                    //}
                    if (message.PropertyName == nameof(SYS_USER.LOGIN_NAME_PropertyChanged) || message.PropertyName == nameof(SYS_USER.PASSWORD_PropertyChanged))
                    {
                        if (String.IsNullOrEmpty(SYS_USER.LOGIN_NAME_PropertyChanged))
                        {
                            LoginErrorMsg = "请输入用户名";
                        }
                        else if (String.IsNullOrEmpty(SYS_USER.PASSWORD_PropertyChanged))
                        {
                            LoginErrorMsg = "请输入密码";
                        }
                        else
                        {
                            LoginErrorMsg = "请点击登录按钮";
                        }
                    }
                });

                //测试消息传递--消息注册--token模式
                Messenger.Default.Register<NotificationMessagerAction<string>>(
                this,
                message =>
                {
                    if (message.Sender?.ToString() == NotificationsToken.test1)
                    {
                        message.Execute("Hello");
                    }
                });
            }
        }

        #endregion

        #region  Command

        private void ExcuteLoadedCommand(RoutedEventArgs e)
        {
            SYS_USER.LOGIN_NAME_PropertyChanged = AppSettings.LoginName;
            if (Debugger.IsAttached)
            {
                SYS_USER.PASSWORD_PropertyChanged = AppSettings.Password;
            }
        }

        private void ExcuteLoginClickCommand()
        {
            //测试消息传递--消息发送--token模式
            Messenger.Default.Send<NotificationMessagerAction<string>>
            (
                new NotificationMessagerAction<string>
                (
                    NotificationsToken.test1,
                    e =>
                    {
                        LoginErrorMsg = e;
                    }
                )
            );

            AppContext.LoginName = SYS_USER.LOGIN_NAME;
            AppContext.Password = SYS_USER.PASSWORD;
            AppSettings.LoginName = SYS_USER.LOGIN_NAME;
            if (Debugger.IsAttached)
            {
                AppSettings.Password = SYS_USER.PASSWORD;
            }

            DialogResult = true;
            var loginViewWindowIntPtr = SimpleIoc.Default.GetInstance<IWindowService>().GetWindowIntPtr(NotificationsToken.LoginViewWindowIntPtr);
            CurrentWindowService.Close(loginViewWindowIntPtr);
        }

        private bool CanExcuteLoginClickCommand()
        {
            if (!IsInDesignMode)
                return !String.IsNullOrEmpty(SYS_USER.LOGIN_NAME_PropertyChanged) && !String.IsNullOrEmpty(SYS_USER.PASSWORD_PropertyChanged);
            return true;
        }

        private void ExcuteCancelClickCommand(SYS_USER e)
        {
            ShutdownWindowAnimateBehaviorService.Animate();
        }

        #endregion
    }
}

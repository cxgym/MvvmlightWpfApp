using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using MvvmlightWpfApp.Messengers;
using MvvmlightWpfApp.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmlightWpfApp.Services
{
    public class WindowService : ViewModelBase, IWindowService
    {
        private Window loginViewWindowIntPtr;
        public Window LoginViewWindowIntPtr
        {
            get { return loginViewWindowIntPtr; }
            set { loginViewWindowIntPtr = value; RaisePropertyChanged(() => LoginViewWindowIntPtr); }
        }

        private Window mainViewWindowIntPtr;
        public Window MainViewWindowIntPtr
        {
            get { return mainViewWindowIntPtr; }
            set { mainViewWindowIntPtr = value; RaisePropertyChanged(() => MainViewWindowIntPtr); }
        }

        public WindowService()
        {
            ////注销当前页面对象所有的注册消息
            //Messenger.Default.Unregister(this);
        }

        public void RegisterWindowIntPtr(FrameworkElement element, string messagetoken)
        {
            if (messagetoken == NotificationsToken.LoginViewWindowIntPtr)
            {
                LoginViewWindowIntPtr = element as Window;
            }
            if (messagetoken == NotificationsToken.MainViewWindowIntPtr)
            {
                MainViewWindowIntPtr = element as Window;
            }
           
            ////这里的参数object一定要注意，不然注册消息不成功，可以去方法里的参数查看原因
            ////object kk1=message.Execute(new object()); 这样写是OK的
            ////不能将token赋值为传进来的值messagetoken
            //Messenger.Default.Register<NotificationMessagerFunc<object, object>>(
            //this,
            //message =>
            //{
            //    if (message.Sender?.ToString() == NotificationsToken.test2)
            //    {
            //        object backvalue=message.Execute(new object());
            //    }
            //});
        }

        public Window GetWindowIntPtr(string messagetoken)
        {
            //Messenger.Default.Send<NotificationMessagerFunc<object, object>>
            //(
            //    new NotificationMessagerFunc<object, object>
            //    (
            //        NotificationsToken.test2,
            //        e =>
            //        {
            //            return new object();   //return e;
            //        }
            //    )
            //);
            if (messagetoken == NotificationsToken.LoginViewWindowIntPtr)
            {
                return LoginViewWindowIntPtr;
            }
            if (messagetoken == NotificationsToken.MainViewWindowIntPtr)
            {
                return MainViewWindowIntPtr;
            }
            return null;
        }
    }
}

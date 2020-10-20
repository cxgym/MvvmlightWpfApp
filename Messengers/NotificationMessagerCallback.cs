using System;
using GalaSoft.MvvmLight.Messaging;

namespace MvvmlightWpfApp.Messengers
{
    public class NotificationMessagerCallback : MessageBase
    {
        private readonly Delegate _callback;

        /// <summary>
        /// 注意这里的base(notification)实际上是把标识token传递给MessageBase
        /// 这样的话在监听messager的地方就可以获取到token了
        /// </summary>
        /// <param name="notification"></param>
        /// <param name="callback"></param>
        public NotificationMessagerCallback(string notification, Delegate callback)
            : base(notification)
        {
            _callback = callback;
        }

        public virtual object Execute(params object[] arguments)
        {
            if (_callback != null)
            {
                return _callback.DynamicInvoke(arguments);
            }

            return null;
        }
    }
}

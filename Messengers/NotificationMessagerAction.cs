using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmlightWpfApp.Messengers
{
    /// <summary>
    /// 消息传递参数类型 
    /// 无返回值的匿名委托
    /// </summary>
    public class NotificationMessagerAction : NotificationMessagerCallback
    {
        public NotificationMessagerAction(string notification, Action callback)
            : base(notification, callback)
        {
        }

        public void Execute()
        {
            base.Execute();
        }
    }

    public class NotificationMessagerAction<T> : NotificationMessagerCallback
    {
        public NotificationMessagerAction(string notification, Action<T> callback)
            : base(notification, callback)
        {
        }

        public void Execute(T param1)
        {
            base.Execute(param1);
        }
    }
}

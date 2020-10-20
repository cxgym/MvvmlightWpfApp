using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmlightWpfApp.Messengers
{
    /// <summary>
    /// 消息传递参数类型
    /// 有返回值的匿名委托
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public class NotificationMessagerFunc<TResult> : NotificationMessagerCallback
    {
        public NotificationMessagerFunc(string notification, Func<TResult> callback)
            : base(notification, callback)
        {
        }

        public TResult Execute()
        {
            return (TResult)base.Execute();
        }
    }

    public class NotificationMessagerFunc<T, TResult> : NotificationMessagerCallback
    {
        public NotificationMessagerFunc(string notification, Func<T,TResult> callback)
            : base(notification, callback)
        {
        }

        public TResult Execute(T param1)
        {
            return (TResult)base.Execute(param1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmlightWpfApp.Messengers
{
    /// <summary>
    /// 消息传递的专用唯一标识token，用于区分信道
    /// </summary>
    public static class NotificationsToken
    {
        public static readonly string test1 = Guid.NewGuid().ToString();

        public static readonly string test2 = Guid.NewGuid().ToString();

        public static readonly string LoginViewWindowIntPtr = Guid.NewGuid().ToString();

        public static readonly string MainViewWindowIntPtr = Guid.NewGuid().ToString();

        public static readonly string GetInstance = Guid.NewGuid().ToString();

        public static readonly string NavpanelControlWindowIntPtr = Guid.NewGuid().ToString();
    }
}

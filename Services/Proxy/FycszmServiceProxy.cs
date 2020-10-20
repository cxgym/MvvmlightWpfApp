using GalaSoft.MvvmLight.Ioc;
using MvvmlightWpfApp.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmlightWpfApp.Services.Proxy
{
    public class FycszmServiceProxy
    {
        #region  实现线程安全的单例模式，这样设计的目的是防止高并发情况下创建了多个实例

        //定义一个保存实例的静态变量
        private static FycszmServiceProxy instance;
        //定义一个保证线程同步安全标识
        private static readonly object synchronized = new object();
        //创建单例实例
        public static FycszmServiceProxy GetInstance()
        {
            lock (synchronized)
            {
                return instance ?? (instance = new FycszmServiceProxy());
            }
        }

        #endregion

        public void Test()
        {
            SimpleIoc.Default.GetInstance<IFycszmService>().Test();
        }
    }
}

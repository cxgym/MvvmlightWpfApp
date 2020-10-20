using MvvmlightWpfApp.Services.Impl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmlightWpfApp.Services
{
    public partial class FycszmService : IFycszmService
    {
        public void Test()
        {
            Debug.WriteLine("测试服务方法");
        }
    }
}

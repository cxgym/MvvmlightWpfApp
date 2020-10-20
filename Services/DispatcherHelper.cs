using GalaSoft.MvvmLight.platform.Threading;
using MvvmlightWpfApp.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmlightWpfApp.Services
{
    public class DispatcherHelper : IDispatcherHelper
    {
        public void CheckBeginInvokeOnUi(Action action)
        {
            GalaSoft.MvvmLight.platform.Threading.DispatcherHelper.CheckBeginInvokeOnUI(action);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmlightWpfApp.Services.Impl
{
    public interface IDispatcherHelper
    {
        void CheckBeginInvokeOnUi(Action action);
    }
}

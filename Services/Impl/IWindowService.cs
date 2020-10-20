using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmlightWpfApp.Services.Impl
{
    public interface IWindowService
    {
        void RegisterWindowIntPtr(FrameworkElement element, string messagetoken);

        Window GetWindowIntPtr(string messagetoken);
    }
}

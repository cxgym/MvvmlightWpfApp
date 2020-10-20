using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmlightWpfApp.Services.Impl
{
    public interface ICurrentWindowService
    {
        //
        // 摘要:
        //     Activates the window associated with the DevExpress.Mvvm.ICurrentWindowService.
        void Activate();
        //
        // 摘要:
        //     Closes the window associated with the DevExpress.Mvvm.ICurrentWindowService.
        void Close(Window windowIntPtr);
        //
        // 摘要:
        //     Hides the window associated with the DevExpress.Mvvm.ICurrentWindowService.
        void Hide();
        //
        // 摘要:
        //     Sets the specified state for the window associated with the DevExpress.Mvvm.ICurrentWindowService.
        //
        // 参数:
        //   state:
        //     A System.Windows.WindowState enumeration value.
        void SetWindowState(WindowState state);
        //
        // 摘要:
        //     Shows the window associated with the DevExpress.Mvvm.ICurrentWindowService.
        void Show();
        //退出当前应用程序
        void Exit(Window windowIntPtr = null);
    }
}

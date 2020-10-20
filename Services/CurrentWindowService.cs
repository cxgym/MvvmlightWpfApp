using MvvmlightWpfApp.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmlightWpfApp.Services
{
    public class CurrentWindowService: ICurrentWindowService
    {

        public void Activate()
        { 
        
        }

        public void Close(Window windowIntPtr)
        {
            windowIntPtr.Close();
        }

        public void Exit(Window windowIntPtr)
        {
            Environment.Exit(0);
            //Application.Current.Shutdown();
        }

        public void Hide()
        { 
        
        }

        public void SetWindowState(WindowState state)
        { 
        
        }

        public void Show()
        { 
        
        }
    }
}

using MvvmlightWpfApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmlightWpfApp
{
    public static class AppSettings
    {
        public static string LoginName
        {
            get => IniHelper.ReadString(nameof(LoginName), AppContext.ConfigPath);
            set => IniHelper.WriteString(nameof(LoginName), value, AppContext.ConfigPath);
        }
        public static string Password
        {
            get => IniHelper.ReadString(nameof(Password), AppContext.ConfigPath);
            set => IniHelper.WriteString(nameof(Password), value, AppContext.ConfigPath);
        }
        public static bool AllowSavePwd
        {
            get => IniHelper.ReadBoolean(nameof(AllowSavePwd), AppContext.ConfigPath);
            set => IniHelper.WriteBoolean(nameof(AllowSavePwd), value, AppContext.ConfigPath);
        }
        public static int? AppFlag
        {
            get => IniHelper.ReadInt(nameof(AppFlag), AppContext.ConfigPath);
            set => IniHelper.WriteInt(nameof(AppFlag), value, AppContext.ConfigPath);
        }
    }
}

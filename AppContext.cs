using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MvvmlightWpfApp
{
    public class AppContext
    {
        /// <summary>
        /// 本地数据文件夹路径
        /// </summary>
        public static string AppDataFolder { get; set; } = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "chenxingroup",
            "4A099D05-5FF3-48AB-BAA2-331BAF99D38F");

        public static string ConfigPath { get; set; }

        public static bool Nologin { get; set; }

        public static string LoginName { get; set; }
        public static string Password { get; set; }
        public static bool AllowSavePwd { get; set; }
        public static int? AppFlag { get; set; }

        static AppContext()
        {
            ConfigPath = Path.Combine(AppDataFolder, "Config.ini");
        }
    }
}

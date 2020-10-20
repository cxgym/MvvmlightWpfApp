using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MvvmlightWpfApp.Utilities
{
    public static class IniHelper
    {
        private const string True = "1";
        private const string False = "0";

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool WritePrivateProfileString(string lpAppName,
            string lpKeyName, string lpString, string lpFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern uint GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            uint nSize,
            string lpFileName);

        private const string DefaultApp = "Default";

        public static void WriteString(string key, string value, string filePath, string section = DefaultApp)
        {
            var dir = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(dir))
            {              
                Directory.CreateDirectory(dir);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }

            if (!WritePrivateProfileString(section, key, value, filePath))
            {
                var errorCode = Marshal.GetLastWin32Error();
                throw new ApplicationException($"写入失败,错误代码:{errorCode}!");
            }
        }

        public static void WriteBoolean(string key, bool value, string filePath, string section = DefaultApp)
        {
            WriteString(key, value ? True : False, filePath, section);
        }

        public static string ReadString(string key, string filePath, string Default = "", string section = DefaultApp)
        {
            if (!File.Exists(filePath)) return string.Empty;
            var sb = new StringBuilder(1024);
            var result = GetPrivateProfileString(section, key, Default, sb, 1024, filePath);
            return sb.ToString();
        }

        public static bool ReadBoolean(string key, string filePath, string section = DefaultApp)
        {
            return ReadString(key, filePath, string.Empty, section) == True;
        }

        public static void CheckEmptyString(string key, string Default, string filePath, string defaultValue,
            string section = DefaultApp)
        {
            if (string.IsNullOrWhiteSpace(ReadString(key, filePath, Default, section)))
            {
                WriteString(key, defaultValue, filePath, section);
            }
        }

        public static int? ReadInt(string key, string filePath, string section = DefaultApp)
        {
            var str = ReadString(key, filePath, string.Empty, section);
            return int.TryParse(str, out int result) ? (int?)result : null;
        }

        public static void WriteInt(string key, int? value, string filePath, string section = DefaultApp)
        {
            WriteString(key, value.ToString(), filePath, section);
        }
    }
}

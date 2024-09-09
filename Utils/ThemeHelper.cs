using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace AntdUIDemo.Utils
{
    public class ThemeHelper
    {
        public static bool IsLightMode()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
            if (key != null)
            {
                int appsUseLightTheme = (int)key.GetValue("AppsUseLightTheme", -1);
                if (appsUseLightTheme == 1)
                {
                    return true;
                }
                return false;
            }
            return true;
        }

        public static void SetColorMode(AntdUI.Window window, bool isLight)
        {
            if (!isLight)
            {
                AntdUI.Config.IsDark = true;// 设置为深色模式
                window.BackColor = Color.FromArgb(31, 31, 31);
                window.ForeColor = Color.White;
            }
            else
            {
                AntdUI.Config.IsLight = true;
                window.BackColor = Color.White;
                window.ForeColor = Color.Black;
            }
        }
    }
}

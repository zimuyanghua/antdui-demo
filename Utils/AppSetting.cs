using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntdUIDemo.Utils
{
    public static class AppSetting
    {
        public static void UpdateAppSetting(string key, string value)
        {
            // 获取当前配置文件
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 检查key是否存在，存在则更新，不存在则添加
            if (config.AppSettings.Settings[key] != null)
            {
                config.AppSettings.Settings[key].Value = value;
            }
            else
            {
                config.AppSettings.Settings.Add(key, value);
            }

            // 保存更改
            config.Save(ConfigurationSaveMode.Modified);

            // 刷新配置节，确保更新被应用
            ConfigurationManager.RefreshSection("appSettings");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntdUIDemo.Utils
{
    public static class AppSetting
    {
        public static void UpdateAppSetting(string key, string value)
        {
            // 获取配置文件路径
            string configFilePath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;

            // 检查配置文件是否存在
            if (!File.Exists(configFilePath))
            {
                // 如果文件不存在，可以选择创建默认的配置文件
                CreateDefaultConfigFile(configFilePath);
            }
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

        private static void CreateDefaultConfigFile(string configFilePath)
        {
            // 创建一个新的配置文件，并写入默认的appSettings
            var configXml = @"<?xml version='1.0' encoding='utf-8' ?>
<configuration>
  <appSettings>
    <add key='ColorMode' value='Auto' />
    <add key='Animation' value='True' />
    <add key='ShadowEnabled' value='True' />
    <add key='ScrollBarHide' value='False' />
    <add key='ShowInWindow' value='True' />
    <add key='ShowOffset' value='0' />
  </appSettings>
</configuration>";

            File.WriteAllText(configFilePath, configXml);
        }
    }
}

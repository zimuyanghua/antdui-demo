using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntdUIDemo.Utils
{
    public class AppSetting
    {
        private static readonly string configFilePath = "appsettings.json";

        public static JObject GetAppSettings(string configFilePath = "appsettings.json")
        {
            if (!File.Exists(configFilePath))
            {
                // 如果文件不存在，创建默认的配置文件
                CreateDefaultConfigFile(configFilePath);
            }

            var json = File.ReadAllText(configFilePath);
            var jsonObj = JObject.Parse(json);

            return (JObject)jsonObj["AppSettings"];
        }

        public static void UpdateAppSetting(string key, string value)
        {
            // 检查配置文件是否存在
            if (!File.Exists(configFilePath))
            {
                // 如果文件不存在，创建默认的配置文件
                CreateDefaultConfigFile(configFilePath);
            }

            // 读取并解析现有的 appsettings.json 文件
            var json = File.ReadAllText(configFilePath);
            var jsonObj = JObject.Parse(json);

            // 获取或创建 "AppSettings" 节点
            var appSettings = jsonObj["AppSettings"] as JObject;
            if (appSettings == null)
            {
                appSettings = new JObject();
                jsonObj["AppSettings"] = appSettings;
            }

            // 检查 key 是否存在，存在则更新，不存在则添加
            if (appSettings[key] != null)
            {
                appSettings[key] = value;
            }
            else
            {
                appSettings.Add(key, value);
            }

            // 保存更改回 appsettings.json 文件
            File.WriteAllText(configFilePath, jsonObj.ToString());
        }

        private static void CreateDefaultConfigFile(string configFilePath)
        {
            // 创建一个新的 appsettings.json 文件，并写入默认的 AppSettings
            var configJson = @"{
  ""AppSettings"": {
    ""ColorMode"": ""Auto"",
    ""Animation"": ""True"",
    ""ShadowEnabled"": ""True"",
    ""ScrollBarHide"": ""False"",
    ""ShowInWindow"": ""True"",
    ""ShowOffset"": ""0""
  }
}";
            File.WriteAllText(configFilePath, configJson);
        }
    }
}

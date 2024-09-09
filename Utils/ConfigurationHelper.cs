using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntdUIDemo.Utils
{
    public class ConfigurationHelper
    {
        public static JObject GetAppSettings(string configFilePath = "appsettings.json")
        {
            if (!File.Exists(configFilePath))
            {
                return null;
            }
            // Read the JSON file
            var json = File.ReadAllText(configFilePath);

            // Parse the JSON object
            var jsonObj = JObject.Parse(json);

            // Return the "AppSettings" section
            return (JObject)jsonObj["AppSettings"];
        }
    }
}

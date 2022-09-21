using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Common
{

    public static class AppSettingHelper
    {
        /// <summary>
        /// 从AppSetting中获取配置数据
        /// </summary>
        /// <param name="key">配置KEY名</param>
        /// <returns></returns> 
        /// <summary>
        public static string GetAppSettingValue(string key)
        {
            if (ConfigurationManager.AppSettings.Get(key) == null)
            {
                throw new Exception("配置节点找不到");
            }
            else
            {
                string value = ConfigurationManager.AppSettings[key];
                return value;
            }
        }

        /// <summary>
        /// 从AppSetting中更新或添加节点信息
        /// </summary>
        /// <param name="key">配置KEY名</param>
        /// <param name="value">配置KEY值</param>
        /// <returns></returns> 
        /// <summary>
        public static void AddUpdateAppSettings(string key, string value)
        {

            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }



    }


}

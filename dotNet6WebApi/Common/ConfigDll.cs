using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ConfigDll
    {
        /// <summary>
        /// 载入配置
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Dictionary<string, string> LoadConfig(string path, string name)
        {
            string config = loadConfig(path, name);
            return DeserializeStringToDictionary<string, string>(config);
        }


        /// <summary>
        /// 载入配置
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public string LoadConfig3(string path, string name)
        {
            string config = loadConfig(path, name);
            return config;
        }

        /// <summary>
        /// 载入配置
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public JObject LoadConfig2(string path, string name)
        {
            string config = loadConfig(path, name);
            return JObject.Parse(config);
        }

        /// <summary>
        /// 载入配置
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public JArray LoadConfig4(string path, string name)
        {
            string config = loadConfig(path, name);
            return JArray.Parse(config);
        }

        /// <summary>
        /// 获取当前DLL所在目录
        /// </summary>
        /// <returns></returns>
        public static string GetHomePath()
        {
            try
            {
                string _CodeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                _CodeBase = _CodeBase.Substring(8, _CodeBase.Length - 8);
                string[] arrSection = _CodeBase.Split(new char[] { '/' });
                string _FolderPath = "";
                for (int i = 0; i < arrSection.Length - 2; i++)
                {
                    _FolderPath += arrSection[i] + "/";
                }
                return _FolderPath;
            }
            catch
            {
                return "../";
            }
        }

        /// <summary>
        /// 将json字符串反序列化为字典类型
        /// </summary>
        /// <typeparam name="TKey">字典key</typeparam>
        /// <typeparam name="TValue">字典value</typeparam>
        /// <param name="jsonStr">json字符串</param>
        /// <returns>字典数据</returns>
        public static Dictionary<TKey, TValue> DeserializeStringToDictionary<TKey, TValue>(string jsonStr)
        {
            if (string.IsNullOrEmpty(jsonStr))
                return new Dictionary<TKey, TValue>();

            Dictionary<TKey, TValue> jsonDict = JsonConvert.DeserializeObject<Dictionary<TKey, TValue>>(jsonStr);

            return jsonDict;

        }

        private static object _objLock = new object();
        private static ConfigDll _instance = null;

        public static ConfigDll Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_objLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ConfigDll();
                        }
                    }
                }
                return _instance;
            }
        }

        private static string configcontent = "";

        /// <summary>
        /// 读取配置
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private string loadConfig(string path, string name)
        {
            if (string.IsNullOrEmpty(configcontent))
            {
                configcontent = readParameterFile(path);
            }
            JObject obj = JObject.Parse(configcontent);
            string token = obj.GetValue(name) == null ? "" : obj.GetValue(name).ToString();
            return token;
        }

        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="file">文件完整路径</param>
        /// <param name="code">文件编码格式</param>
        /// <returns>文件内容</returns>
        private string readParameterFile(string path)
        {
            if (!File.Exists(path))
            {
                return "";
            }
            try
            {
                StreamReader objReader = new StreamReader(path, Encoding.UTF8);
                string text = objReader.ReadToEnd();
                objReader.Close();
                return text;
            }
            catch { return ""; }
        }
    }
}

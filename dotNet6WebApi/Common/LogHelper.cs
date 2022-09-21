using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Threading;
using System.Web;
using System.Xml.Serialization;

namespace Common
{

    #region 日志对象

    public class AppLog
    {
        #region 单件模式
        private static AppLog instance = null;
        private static readonly Object o = new Object();
        /// <summary>
        /// 获取日志对象实例
        /// </summary>
        public static AppLog Instance
        {
            get
            {
                try
                {
                    if (instance == null)
                    {
                        lock (o)
                        {
                            if (instance == null)
                            {
                                instance = new AppLog();
                            }
                        }
                    }

                    return instance;
                }
                catch { return null; }
            }
        }
        #endregion

        /// <summary>
        /// 搜索日志队列后，休眠时间（单位：毫秒）
        /// </summary>
        private const Int32 _sleepTime = 200;
        /// <summary>
        /// 日志配置对象
        /// </summary>
        private LogConfig logcfg;
        /// <summary>
        /// 待保存日志队列
        /// </summary>
        private Queue logQueue;
        /// <summary>
        /// 日志保存路径（默认为调用程序的 .\AppLog）
        /// </summary>
        public String LogPath
        {
            get { return logcfg.LogPath; }
            set
            {
                if (Directory.Exists(value))
                    logcfg.LogPath = value;
            }
        }
        /// <summary>
        /// 是否保存操作日志
        /// </summary>
        public Boolean AutoWriteLog
        {
            get { return logcfg.AutoWriteLog; }
            set { logcfg.AutoWriteLog = value; }
        }

        public Boolean NotSaveSelect
        {
            get { return logcfg.NotSaveSelect; }
            set { logcfg.NotSaveSelect = value; }
        }
        /// <summary>
        /// 保存数据库操作日志的配置
        /// </summary>
        public void SaveConfig()
        {
            try
            {
                string fullpath = string.Format(@"{0}\cfg\DbLogCfg.Xml", HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath));
                XmlSerializer cfg = new XmlSerializer(typeof(LogConfig));
                Stream s = new FileStream(fullpath, FileMode.Create, FileAccess.Write, FileShare.None);
                cfg.Serialize(s, logcfg);
                s.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        /// <summary>
        /// 读取日志配置文件
        /// </summary>
        public void LoadConfig()
        {
            try
            {
                string fullpath = string.Format(@"{0}\cfg\DbLogCfg.Xml", HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath));
                if (File.Exists(fullpath))
                {
                    XmlSerializer cfg = new XmlSerializer(typeof(LogConfig));
                    FileStream s = new FileStream(fullpath, FileMode.Open, FileAccess.Read, FileShare.Read);
                    logcfg = (LogConfig)cfg.Deserialize(s);
                    s.Close();
                }
                else
                {
                    logcfg = new LogConfig();
                }
            }
            catch { logcfg = new LogConfig(); }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="logpath">日志保存路径</param>
        private AppLog()
        {
            LoadConfig();

            if (!Directory.Exists(logcfg.LogPath))
            {
                Directory.CreateDirectory(logcfg.LogPath);
            }

            logQueue = new Queue();

            //写日志线程
            Thread logThread = new Thread(new ThreadStart(writeLog2File));
            logThread.Priority = ThreadPriority.Lowest;
            //以后台线程模式，将不必显示关闭该线程，但有丢失日志信息的可能
            logThread.IsBackground = true;
            logThread.Start();
        }

        /// <summary>
        /// 写入信息到日志文件
        /// </summary>
        /// <param name="log"></param>
        /// <param name="fs"></param>
        private void write(String log, StreamWriter fs)
        {
            fs.WriteLine(log);
        }
        /// <summary>
        /// 打开日志文件
        /// </summary>
        /// <returns></returns>
        private StreamWriter openLogFile4Append()
        {
            try
            {
                return File.AppendText(String.Format(@"{0}\{1}.Log", logcfg.LogPath, DateTime.Now.ToLongDateString()));
            }
            catch { return null; }
        }
        /// <summary>
        /// 关闭日志文件
        /// </summary>
        /// <param name="fs"></param>
        /// <returns></returns>
        private Boolean closeLogFile(StreamWriter fs)
        {
            try
            {
                fs.Close();
                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// 从日志队列获取信息
        /// </summary>
        /// <returns></returns>
        private String getLog()
        {
            String log = "";
            lock (logQueue)
            {
                if (logQueue.Count > 0)
                {
                    log = (String)logQueue.Dequeue();
                }
            }
            return log;
        }
        /// <summary>
        /// 写入信息到日志队列
        /// </summary>
        /// <param name="log">日志内容</param>
        public void WriteLog(String log)
        {
            lock (logQueue)
            {
                if (logcfg.AutoWriteLog)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("\n################################# START {0} ############################################### \n",DateTime.Now.ToString());
                    sb.Append(log);
                    sb.AppendFormat("\n################################# END  {0} ############################################### \n", DateTime.Now.ToString());
                    logQueue.Enqueue(sb.ToString());
                }
            }
        }
        /// <summary>
        /// 写日志线程
        /// </summary>
        private void writeLog2File()
        {
            while (true)
            {
                if (logQueue.Count > 0)
                {
                    StreamWriter fs = openLogFile4Append();
                    if (fs != null)
                    {
                        while (logQueue.Count > 0)
                        {
                            String log = getLog();
                            write(log, fs);
                        }
                        closeLogFile(fs);
                    }
                }
                Thread.Sleep(_sleepTime);
            }
        }
    }
    #endregion

    #region 日志配置
  
    public class LogConfig
    {
        /// <summary>
        /// 是否保存操作日志
        /// </summary>
        public Boolean AutoWriteLog = true;
        /// <summary>
        /// 不保存正确执行的Select语句操作日志
        /// </summary>
        public Boolean NotSaveSelect = true;
        /// <summary>
        /// 日志保存路径（默认为调用程序的 .\AppLog）
        /// </summary>
        public String LogPath = $"{ AppDomain.CurrentDomain.BaseDirectory}\\AppLog";
    }
    #endregion


}

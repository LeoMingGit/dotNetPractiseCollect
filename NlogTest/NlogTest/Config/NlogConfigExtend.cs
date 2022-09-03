using NLog;
using NLog.Extensions.Logging;

namespace NlogTest.Config
{

    /// <summary>
    /// 扩展类
    /// </summary>
    public static class NlogConfigExtend
    {
        public static void Register(this WebApplicationBuilder builder)
        {

            ///注入
            var services = builder.Services;
            services.AddLogging(log =>
            {
                log.AddConsole();
                log.AddNLog();
            });
          

        }

    }
}

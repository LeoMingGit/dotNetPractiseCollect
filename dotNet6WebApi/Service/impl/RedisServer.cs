using CSRedis;
using Microsoft.Extensions.Configuration;
namespace Service.impl
{
    public class RedisServer
    {
        private CSRedisClient _database;
        private string configurationString;
        private int _currentDatabaseId = 0;



        public RedisServer(IConfiguration configuration)
        {
            CreateRedisConfigurationString(configuration);
            var csredis = new CSRedisClient(configurationString);
            RedisHelper.Initialization(csredis);
        }

        public RedisHelper RedisHelper => _RedisHelper;

        public void FlushDatabase()
        {

        }

        private void CreateRedisConfigurationString(IConfiguration configuration)
        {
            configurationString = configuration.GetSection("RedisConfiguration:connectionString").Value;
        }
    }
}

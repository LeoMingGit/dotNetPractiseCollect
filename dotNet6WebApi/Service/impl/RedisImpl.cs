using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Service.interfaces;
using CSRedis;

namespace Service.impl
{
    public class RedisImpl : IRedis
    {

        public RedisImpl(IConfiguration configuration)
        {
            string configurationString = configuration.GetSection("RedisConfiguration:connectionString").Value;
            var csredis = new CSRedisClient(configurationString);
            RedisHelper.Initialization(csredis);

        }

        public void Add(string key, object data)
        {
            string jsonData = JsonConvert.SerializeObject(data);
            RedisHelper.Set(key, jsonData);

        }

        public bool Any(string key)
        {
            return RedisHelper.Exists(key);
        }

        public T Get<T>(string key)
        {
            if (Any(key))
            {
                string jsonData = RedisHelper.Get(key);
                return JsonConvert.DeserializeObject<T>(jsonData);
            }

            return default;
        }

        public void Remove(string key)
        {
            RedisHelper.Del(key);
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using StackExchange.Redis;
namespace RatingApi.RedisDatabase 
{
    public class RedisDatabaseProvider : IRedisDatabaseProvider
    {    
        private ConnectionMultiplexer _redisMultiplexer;
    
        public IDatabase GetDatabase()
        {
            if (_redisMultiplexer == null)
            {
                var redisAddr = Environment.GetEnvironmentVariable("REDIS_ADDR") ?? "127.0.0.1:6379";
                _redisMultiplexer = ConnectionMultiplexer.Connect(redisAddr);
            }
            return _redisMultiplexer.GetDatabase();
        }
    }
}
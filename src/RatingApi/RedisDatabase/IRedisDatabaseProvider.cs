using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace RatingApi.RedisDatabase
{
    public interface IRedisDatabaseProvider
    {
        IDatabase GetDatabase();
    }
}
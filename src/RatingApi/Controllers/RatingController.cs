using System;
using Microsoft.AspNetCore.Mvc;
using RatingApi.Models;
using RatingApi.RedisDatabase;

namespace RatingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RatingController : ControllerBase
    {
        private readonly IRedisDatabaseProvider _redisDatabaseProvider;
        public RatingController(IRedisDatabaseProvider redisDatabaseProvider)
        {
            _redisDatabaseProvider = redisDatabaseProvider;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Rating> Get(string id)
        {
            var db = _redisDatabaseProvider.GetDatabase();
            var value = db.StringGet(id);
            return new Models.Rating {Key= id, Value= Double.Parse(value)};
        }
    }
}
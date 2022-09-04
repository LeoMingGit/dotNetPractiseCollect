using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using NAutowired.Core.Attributes;
using 依赖注入.Logic;

namespace 依赖注入.Controllers
{
    /// <summary>
    /// 参考网站： https://github.com/kirov-opensource/NAutowired
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        [Autowired(typeof(MyService01))]
        private IService _mySer01;
        [Autowired(typeof(MyService02))]
        private IService _mySer02;

        /// <summary>
        /// 字段的注入
        /// </summary>
        [Autowired]
        private IOptions<SnowflakeConfig> options { get; set; }


        [Route("Ser01")]
        [HttpGet]
        public JsonResult Ser01()
        {
            string str = _mySer01.SayHi();
            return new JsonResult(str);
        }


        [Route("Ser02")]
        [HttpGet]
        public JsonResult Ser02()
        {
            string str = _mySer02.SayHi();
            return new JsonResult(str);
        }

        [HttpGet("snowflake")]

        public IActionResult Test03()
        {
            return Ok(options.Value);
        }
    }
}

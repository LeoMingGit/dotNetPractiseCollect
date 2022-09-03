using Microsoft.AspNetCore.Mvc;
using NlogTest.BLL;

namespace NlogTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoggingTestController : ControllerBase
    {
        private readonly ILogger<LoggingTestController> _logger;
        private readonly SysBLL bll;
        private readonly SqlLogic logic;


        public LoggingTestController(ILogger<LoggingTestController> logger)
        {
            _logger = logger;
            bll = new SysBLL();
            logic = new SqlLogic();

        }

        [Route("Test01")]
        [HttpGet]
        public  Object Test01(int id=11111)
        {
            try
            {
                bll.QueryUsers();
                return "OK";
            }
            catch (Exception ex)
            {
                _logger.LogError("Msg:" + ex.Message + "\n stackTrace:" + ex.StackTrace, id);
                return "Error";
            }
        }
        [Route("SQLTest01")]
        [HttpGet]
        public Object SQLTest01(int id = 11111)
        {
            try
            {
                logic.Test01();
                return "OK";
            }
            catch (Exception ex)
            {
                _logger.LogError("Msg:" + ex.Message + "\n stackTrace:" + ex.StackTrace, id);
                return "Error";
            }
        }
    }
}

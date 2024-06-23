using Microsoft.AspNetCore.Mvc;
using Service.interfaces;

namespace dotNet6WebApi.Controllers
{

    /// <summary>
    /// 多线程
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TaskRunController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        private readonly IRedis _redis;
        private readonly ITaskRunService _taskRunService;

 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="redis"></param>
        /// <param name="taskRunService"></param>
        public TaskRunController(ILogger<AuthController> logger, IRedis redis, ITaskRunService taskRunService)
        {
            _logger = logger;
            _redis = redis;
            _taskRunService = taskRunService;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("GetMonitorData")]
        [HttpGet]
        public async Task<IActionResult> GetMonitorData()
        {
            try
            {
                var result = await _taskRunService.GetMonitorDataList();

                if (result != null && result.Any())
                {
                    return Ok(result); // Returns HTTP 200 with the list
                }
                else
                {
                    return StatusCode(204, "No data found."); // Returns HTTP 204 (No Content) if the list is empty
                }
            }
            catch (Exception ex)
            {
                // Log the exception (logging not shown here)
                return StatusCode(500, $"Internal server error: {ex.Message}"); // Returns HTTP 500 with the error message
            }
        }
    }
}

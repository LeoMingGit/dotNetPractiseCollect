using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs;
using Model.VOs;
using System.Text;
using Common.Extensions;
using Service.interfaces;
using Microsoft.AspNetCore.Cors;

namespace dotNet6WebApi.Controllers
{

    /// <summary>
    /// 鉴权模块
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly ILogger<AuthController> _logger;

        private readonly IRedis _redis;
        private readonly IAuthenticationService _authenticationService;


        public AuthController(ILogger<AuthController> logger, IRedis redis, IAuthenticationService authenticationService)
        {
            _logger = logger;
            _redis = redis;
            _authenticationService = authenticationService;
        }

        [EnableCors("AnotherPolicy")]
        [HttpPost]
        [Route("GetToken")]
        public ApiResult GetToken([FromBody] GetTokenRequest param)
        {
            try
            {
                if (ModelState.IsValid == false)
                {
                    return new ApiResult()
                    {
                        code = (int)ResultCode.FAIL,
                        message = ModelState.GetErrorMessages()
                    };
                }
                return _authenticationService.CreateAccessToken(param);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.GetErrorMsg(param));
                return new ApiResult((int)ResultCode.FAIL, "接口发生异常");
            }
        }




    }


}

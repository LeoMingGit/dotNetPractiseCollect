using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model.VOs
{
    public class ApiResult
    {
        /// <summary>
        /// 操作消息【当Status不为 200时，显示详细的错误信息】
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// 操作状态码，10000为正常
        /// </summary>
        public int code { get; set; }

        public ApiResult(int _code = (int)ResultCode.SUCCESS, string _msg = "操作成功")
        {
            code = _code;
            message = _msg;
        }
    }


    /// <summary>
    /// WEBAPI通用返回泛型基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResult<T> : ApiResult
    {
        /// <summary>
        /// 回传的结果
        /// </summary>
        public T data { get; set; }
        public ApiResult(T extra)
        {
            this.data = extra;
        }
    }


    public enum ResultCode
    {
        [Description("操作成功")]
        SUCCESS = 10000,
        [Description("操作失败")]
        FAIL = 10024,
        [Description("参数错误")]
        PARAM_ERROR = 101,

        [Description("验证码错误")]
        CAPTCHA_ERROR = 103,

        [Description("登录错误")]
        LOGIN_ERROR = 105,

        [Description("服务端出错啦")]
        GLOBAL_ERROR = 500,

        [Description("自定义异常")]
        CUSTOM_ERROR = 110,

        [Description("非法请求")]
        INVALID_REQUEST = 116,

        [Description("授权失败")]
        OAUTH_FAIL = 201,

        [Description("未授权")]
        DENY = 401,

        [Description("授权访问失败")]
        FORBIDDEN = 403,

        [Description("Bad Request")]
        BAD_REQUEST = 400
    }
}

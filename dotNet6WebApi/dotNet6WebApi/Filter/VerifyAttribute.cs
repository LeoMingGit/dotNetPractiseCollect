using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Model.VOs;
using Microsoft.Extensions.DependencyInjection;
using Common;
using System.Web;
using System.Text;
using Microsoft.AspNetCore.Http;
using Common.Extensions;
namespace OuterWebApi.Filter
{
    /// <summary>
    /// 授权校验访问
    /// 如果跳过授权登录在Action 或controller加上 AllowAnonymousAttribute
    /// </summary>
    public class VerifyAttribute : Attribute, IAuthorizationFilter
    {

        /// <summary>
        /// 只判断token是否正确，不判断权限
        /// 如果需要判断权限的在Action上加上ApiActionPermission属性标识权限类别，ActionPermissionFilter作权限处理
        /// </summary>
        /// <param name="context"></param>
        public async void OnAuthorization(AuthorizationFilterContext context)
        {
            var noNeedCheck = false;
            if (context.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
            {
                noNeedCheck = controllerActionDescriptor.MethodInfo.GetCustomAttributes(inherit: true)
                  .Any(a => a.GetType().Equals(typeof(AllowAnonymousAttribute)));
            }

            if (noNeedCheck) return;

            string url = context.HttpContext.Request.Path;

            //使用jwt token校验2022 09-14 
            var info = context.HttpContext.Request.Headers["Authorization"].Count == 0 ? "" : context.HttpContext.Request.Headers["Authorization"].ToString();

            SHA256HeaderResult sHA256HeaderResult = new SHA256HeaderResult()
            {
                Timestamp = context.HttpContext.Request.Headers["Timestamp"].Count == 0 ? "" : context.HttpContext.Request.Headers["Timestamp"].ToString(),
                Signature = context.HttpContext.Request.Headers["Signature"].Count == 0 ? "" : context.HttpContext.Request.Headers["Signature"].ToString(),
                Nonce = context.HttpContext.Request.Headers["Nonce"].Count == 0 ? "" : context.HttpContext.Request.Headers["Nonce"].ToString(),
                ext_app_id = context.HttpContext.Request.Headers["ext-app-id"].Count == 0 ? "" : context.HttpContext.Request.Headers["ext-app-id"].ToString(),
            };
            if (sHA256HeaderResult.IsNotEmptyAndValid() == false)
            {
                string msg = $"请求访问[{url}]失败，无法访问系统资源";
                context.Result = new JsonResult(new ApiResult((int)ResultCode.DENY, msg));
                return;
            }
            DateTime requestDateTime = CommonHelper.JavaTimeStampToDateTime(double.Parse(sHA256HeaderResult.Timestamp));
            if (requestDateTime.InRange(DateTime.Now.AddMinutes(-15), DateTime.Now.AddMinutes(15)) == false)
            {
                string msg = $"请求访问[{url}]失败，无法访问系统资源";
                context.Result = new JsonResult(new ApiResult((int)ResultCode.DENY, msg));
                return;
            }
            string bodystr = "";
            context.HttpContext.Request.Body.Seek(0, SeekOrigin.Begin);
            using (StreamReader reader
                      = new StreamReader(context.HttpContext.Request.Body, Encoding.UTF8))
            {
                bodystr = await reader.ReadToEndAsync();
            }
            var AuService = context.HttpContext.RequestServices.GetService(typeof(Service.interfaces.IAuthenticationService)) as Service.impl.AuthenticationService;
            ApiResult res = AuService?.CheckIsAuth(sHA256HeaderResult, bodystr);
            if (res?.code == (int)ResultCode.SUCCESS)
            {
                context.Result = new JsonResult(AuService?.CheckIsAuth(sHA256HeaderResult, bodystr));
            }
            // var isAuthed = context.HttpContext.User.Identity?.IsAuthenticated;

            //if (string.IsNullOrEmpty(info) || isAuthed == false)
            //{
            //    string msg = $"请求访问[{url}]失败，无法访问系统资源";

            //    context.Result = new JsonResult(new ApiResult((int)ResultCode.DENY, msg));
            //}
        }
    }
}

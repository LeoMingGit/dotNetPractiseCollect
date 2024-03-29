﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using JwtWebApiDemo.Result;
namespace JwtWebApiDemo.Filters
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
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var noNeedCheck = false;
            if (context.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
            {
                noNeedCheck = controllerActionDescriptor.MethodInfo.GetCustomAttributes(inherit: true)
                  .Any(a => a.GetType().Equals(typeof(AllowAnonymousAttribute)));
            }

            if (noNeedCheck) return;

            string url = context.HttpContext.Request.Path;

            var info = context.HttpContext.Request.Headers["Authorization"].Count == 0 ? "" : context.HttpContext.Request.Headers["Authorization"].ToString();
            var identity = context.HttpContext.User.Identity;
            var isAuthed = identity?.IsAuthenticated;

            if (string.IsNullOrEmpty(info) ||isAuthed==false)
            {
                string msg = $"请求访问[{url}]失败，无法访问系统资源";

                context.Result = new JsonResult(new ApiResult((int)ResultCode.DENY, msg));
            }
        }
    }
}

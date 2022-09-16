using Common;
using Microsoft.Extensions.Configuration;
using Model.DTOs;
using Model.Models;
using Model.VOs;
using Service.Config;
using Service.interfaces;
using Service.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.impl
{
    public class AuthenticationService : IAuthenticationService
    {

        private readonly IUserManagerService userService;

        private readonly ITokenHandler tokenHandler;

        private readonly IConfiguration configuration;

        private readonly IUserManagerRepository userManagerRepository;
        public AuthenticationService(IUserManagerService userService, ITokenHandler tokenHandler, IConfiguration configuration, IUserManagerRepository userManagerRepository)
        {
            this.userService = userService;
            this.tokenHandler = tokenHandler;
            this.configuration = configuration;
            this.userManagerRepository = userManagerRepository;
        }

        /// <summary>
        /// 首次访问，发放token
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public ApiResult CreateAccessToken(GetTokenRequest param)
        {
            ApiResult<UserManager> userResponse = userService.QueryUser(param);

            if (userResponse.code == (int)ResultCode.SUCCESS)
            {
                AccessToken accessToken = tokenHandler.CreateAccessToken(userResponse.data);

                userService.SaveRefreshToken(userResponse.data.Id.ToString(), accessToken.RefreshToken);

                return new ApiResult<AccessToken>(accessToken);
            }
            else
            {
                return new ApiResult((int)ResultCode.FAIL, "操作失败");
            }
        }

        /// <summary>
        /// 刷新token
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        public ApiResult CreateAccessTokenByRefreshToken(string refreshToken)
        {
            return null;
            //ApiResult<UserManager> userResponse = userService.GetUserWithRefreshToken(refreshToken);

            //if (userResponse.Success)
            //{
            //    if (userResponse.Extra.RefreshTokenEndDate > DateTime.Now)
            //    {
            //        AccessToken accessToken = tokenHandler.CreateAccessToken(userResponse.Extra);

            //        userService.SaveRefreshToken(userResponse.Extra.Id, accessToken.RefreshToken);

            //        return new ApiResult<AccessToken>(accessToken);
            //    }
            //    else
            //    {
            //        return new ApiResult<AccessToken>("refreshtoken suresi dolmus");
            //    }
            //}
            //else
            //{
            //    return new ApiResult((int)ResultCode.FAIL, "操作失败");
            //}
        }

        /// <summary>
        /// 撤销token
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        public ApiResult RevokeRefreshToken(string refreshToken)
        {
            return null;
            //ApiResult<UserManager> userResponse = userService.GetUserWithRefreshToken(refreshToken);

            //if (userResponse.Success)
            //{
            //    userService.RemoveRefreshToken(userResponse.Extra);

            //    return new ApiResult<AccessToken>(new AccessToken());
            //}
            //else
            //{
            //    return new ApiResult((int)ResultCode.FAIL, "操作失败");
            //}
        }

        public ApiResult CheckIsAuth(SHA256HeaderResult head, string bodystr)
        {
            var user = userManagerRepository.QueryUserInfoById(head.ext_app_id);
            if (user == null)
            {
                return new ApiResult((int)ResultCode.FAIL, "操作失败");

            }
            string hashstr = SHA256Helper.Instance.digest("", bodystr, head.Timestamp, head.Nonce, user.AppSecret);
            if (head.Signature.Equals(hashstr) == false)
            {
                return new ApiResult((int)ResultCode.FAIL, "操作失败");
            }
            return new ApiResult((int)ResultCode.SUCCESS, "操作成功");

        }

    }
}

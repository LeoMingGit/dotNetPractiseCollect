using Model.DTOs;
using Model.Models;
using Model.VOs;
using Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.impl

{
    public class UserService : IUserManagerService
    {
        public ApiResult<UserManager> QueryUser(GetTokenRequest param)
        {
            UserManager userManager = new UserManager();
            userManager.Id = "111";
            userManager.Name = "dfada";
            userManager.SurName = "dadfafa";
            userManager.Email = "ddd@qq.com";
            return new ApiResult<UserManager>(userManager);
        }
        public void SaveRefreshToken(string usercode, string refreshToken)
        {
            //保存到数据库
        }
    }
}

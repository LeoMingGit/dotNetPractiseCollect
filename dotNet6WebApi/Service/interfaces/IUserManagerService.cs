using Model.DTOs;
using Model.Models;
using Model.VOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.interfaces
{
    public interface IUserManagerService
    {

        ApiResult<UserManager> QueryUser(GetTokenRequest param);
        void SaveRefreshToken(string usercode, string refreshToken);

    }
}

using Common;
using Model.DTOs;
using Model.VOs;
using Service.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.interfaces
{
    public interface IAuthenticationService
    {
        ApiResult CreateAccessToken(GetTokenRequest param);

        ApiResult CreateAccessTokenByRefreshToken(string refreshToken);

        ApiResult RevokeRefreshToken(string refreshToken);

        ApiResult CheckIsAuth(SHA256HeaderResult head, string bodystr);
    }
}

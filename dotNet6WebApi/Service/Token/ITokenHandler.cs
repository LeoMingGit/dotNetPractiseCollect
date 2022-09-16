using Model.Models;
using System.Security.Claims;
using Service.Config;
namespace Service.Token
{
    public interface ITokenHandler
    {
        AccessToken CreateAccessToken(UserManager user);

        void RevokeRefreshToken(UserManager user);

        string BuildToken(IEnumerable<Claim> claims, TokenOptions options);
    }
}

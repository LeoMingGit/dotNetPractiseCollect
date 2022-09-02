using JwtWebApiDemo.Common;
using JwtWebApiDemo.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace JwtWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;

        }



        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginUser loginDto, [FromServices] IOptions<JWTTokenOptions> jwtOptions)
        {
            //User Authentication
            if (ModelState.IsValid == false)
            {
                return BadRequest("UserId or Password can not be empty");
            }
            //先要在数据库中根据用户的名称和密码比一下，如果匹配上了，则发放令牌
            // 此处省略 ...

            if (CheckLogin(loginDto.UserId,loginDto.PassWord))
            {
                //to do :发放令牌
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, "userid"));//写死
                claims.Add(new Claim(ClaimTypes.Name, "UserName"));
                claims.Add(new Claim(ClaimTypes.Role, "role"));
                string jwtToken = BuildToken(claims, jwtOptions.Value);
                return Ok(jwtToken);
            }
            return Forbid();

        }
        /// <summary>
        /// 生成secretkey
        /// </summary>
        /// <returns></returns>
        [Route("GenerateSecretKey")]
        [HttpGet]
        public string GenerateSecretKey()
        {
            var key = new byte[32];
            RandomNumberGenerator.Create().GetBytes(key);
            var base64Secret = UrlBase64.Encode(key);
            return base64Secret;
        }
        private static string BuildToken(IEnumerable<Claim> claims, JWTTokenOptions options)
        {
            DateTime expires = DateTime.Now.AddSeconds(options.ExpireSeconds);
            byte[] keyBytes = Encoding.UTF8.GetBytes(options.SigningKey);
            var secKey = new SymmetricSecurityKey(keyBytes);
            var credentials = new SigningCredentials(secKey,
                SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(expires: expires,
                signingCredentials: credentials, claims: claims);
            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }

        private  bool  CheckLogin(string usr,string pwd)
        {
            return true;
        }
       
    }
}

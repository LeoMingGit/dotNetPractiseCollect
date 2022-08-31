using JwtWebApiDemo.Common;
using JwtWebApiDemo.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
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

        private List<string> GetRoles(string id)
        {
            List<string> lst = new List<string>();
            lst.Add("admin");
            return lst;
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginUser loginDto, [FromServices] IOptions<JWTTokenOptions> jwtOptions)
        {
            //User Authentication
            if (string.IsNullOrWhiteSpace(loginDto.UserId) || string.IsNullOrWhiteSpace(loginDto.PassWord))
            {
                return BadRequest("UserId or Password can not be empty");
            }
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, loginDto.UserId.ToString()));
            var roles = GetRoles(loginDto.UserId);
            foreach (string role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            string jwtToken = BuildToken(claims, jwtOptions.Value);
            return Ok(jwtToken);

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
            byte[] keyBytes = Encoding.UTF8.GetBytes(options.SecurityKey);
            var secKey = new SymmetricSecurityKey(keyBytes);
            var credentials = new SigningCredentials(secKey,
                SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(expires: expires,
                signingCredentials: credentials, claims: claims);
            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }
       
    }
}

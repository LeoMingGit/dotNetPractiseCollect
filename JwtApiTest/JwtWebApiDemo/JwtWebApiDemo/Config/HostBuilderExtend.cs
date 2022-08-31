using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text;
using JwtWebApiDemo.Model;

namespace JwtWebApiDemo.Config
{
    /// <summary>
    /// 扩展类
    /// </summary>
    public static class HostBuilderExtend
    {
        public static void Register(this WebApplicationBuilder builder)
        {
       
            //第一步，注册JWT
           // builder.Services.Configure<JWTTokenOptions>(builder.Configuration.GetSection("JWTTokenOptions"));
            var services = builder.Services;

            services.Configure<JWTTokenOptions>(builder.Configuration.GetSection("JWT"));

            #region JWT校验
            //第二步，增加鉴权逻辑
            //JWTTokenOptions tokenOptions = new JWTTokenOptions();
            //builder.Configuration.Bind("JWTTokenOptions", tokenOptions);
            //builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)//Scheme
            // .AddJwtBearer(options =>  //这里是配置的鉴权的逻辑
            // {
            //     options.TokenValidationParameters = new TokenValidationParameters
            //     {
            //         //JWT有一些默认的属性，就是给鉴权时就可以筛选了
            //         ValidateIssuer = true,//是否验证Issuer
            //         ValidateAudience = true,//是否验证Audience
            //         ValidateLifetime = true,//是否验证失效时间
            //         ValidateIssuerSigningKey = true,//是否验证SecurityKey
            //         ValidAudience = tokenOptions.Audience,//
            //         ValidIssuer = tokenOptions.Issuer,//Issuer，这两项和前面签发jwt的设置一致
            //         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey))//拿到SecurityKey 
            //     };
            // });
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(x =>
{
    var jwtOpt = builder.Configuration.GetSection("JWT").Get<JWTTokenOptions>();
    byte[] keyBytes = Encoding.UTF8.GetBytes(jwtOpt.SecurityKey);
    var secKey = new SymmetricSecurityKey(keyBytes);
    x.TokenValidationParameters = new()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = secKey
    };
});
            #endregion

            //添加跨域策略
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", opt => opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().WithExposedHeaders("X-Pagination"));
            });
            //设置Json返回的日期格式
            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            });
        }
    }
}

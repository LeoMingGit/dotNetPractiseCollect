using NLog.Extensions.Logging;
using Service.impl;
using Service.interfaces;
using Service.Token;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using Service.Config;
using Model.Base;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Newtonsoft.Json;
//using dotNet6WebApi.Filter;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<BaseDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionString:DbConn"]);
});

builder.Services.AddControllers();
builder.Services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v0", new OpenApiInfo { Title = "dotNet6WebApi", Version = "1.0.0.0" }); // 获取xml文件名
    c.IncludeXmlComments(string.Format("{0}//Swagger.XML", AppDomain.CurrentDomain.BaseDirectory), true);
});
// DI注入
builder.Services.AddSingleton<IRedis, RedisImpl>();
builder.Services.AddScoped<ITokenHandler, TokenHandler>();
builder.Services.AddScoped<IUserManagerService, UserService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IUserManagerRepository, UserManagerRepository>();



builder.Services.Configure<TokenOptions>(builder.Configuration.GetSection("TokenOptions"));

var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(jwtbeareroptions =>
{
    jwtbeareroptions.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = SignHandler.GetSecurityKey(tokenOptions.SecurityKey),
    };
});

//nlog模块
builder.Services.AddLogging(log =>
{
    log.AddConsole();
    log.AddNLog();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var scheme = new OpenApiSecurityScheme()
    {
        Description = "JWT授权(数据将在请求头中进行传输) 直接在下框中输入Bearer {token}(注意两者之间有一个空格)",
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "Authorization"
        },
        Scheme = "oauth2",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
    };
    c.AddSecurityDefinition("Authorization", scheme);
 //   c.OperationFilter<AddRequiredHeaderParameter>();
    var requirement = new OpenApiSecurityRequirement();
    requirement[scheme] = new List<string>();
    c.AddSecurityRequirement(requirement);
});
//https://www.cnblogs.com/kzwrcom/p/11414048.html
builder.Services.AddCors(options =>
{
    options.AddPolicy("AnotherPolicy", builder =>
    {
        builder.AllowAnyHeader()
               .AllowAnyMethod()
               .AllowAnyOrigin()
               .AllowCredentials()
               .WithExposedHeaders("Access-Control-Expose-Headers"); // params string[]
    });
});

var app = builder.Build();//上面配置完成 ，最后一步Build,否则会报错

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseRouting(); //Swagger面板
    app.UseSwagger();
    app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v0/swagger.json", "dotNet6WebApi"); });
}
//.net 6程序可以读取Request.Body内容
app.Use((context, next) =>
{
    context.Request.EnableBuffering();
    return next();
});
app.UseHttpsRedirection();
#region jwt 模块必须写这个
//1.先开启认证
app.UseAuthentication();
//2.再开启授权
app.UseAuthorization();
#endregion
app.MapControllers();

app.Run();

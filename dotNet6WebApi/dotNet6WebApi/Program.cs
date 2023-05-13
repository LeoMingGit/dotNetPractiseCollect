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
    c.SwaggerDoc("v0", new OpenApiInfo { Title = "dotNet6WebApi", Version = "1.0.0.0" }); // ��ȡxml�ļ���
    c.IncludeXmlComments(string.Format("{0}//Swagger.XML", AppDomain.CurrentDomain.BaseDirectory), true);
});
// DIע��
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

//nlogģ��
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
        Description = "JWT��Ȩ(���ݽ�������ͷ�н��д���) ֱ�����¿�������Bearer {token}(ע������֮����һ���ո�)",
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


var app = builder.Build();//����������� �����һ��Build,����ᱨ��
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseRouting(); //Swagger���
    app.UseSwagger();
    app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v0/swagger.json", "dotNet6WebApi"); });
}
//.net 6������Զ�ȡRequest.Body����
app.Use((context, next) =>
{
    context.Request.EnableBuffering();
    return next();
});
app.UseHttpsRedirection();
#region jwt ģ�����д���
//1.�ȿ�����֤
app.UseAuthentication();
//2.�ٿ�����Ȩ
app.UseAuthorization();
#endregion
app.MapControllers();

app.Run();

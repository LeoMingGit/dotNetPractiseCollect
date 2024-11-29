using Microsoft.EntityFrameworkCore;
using Model.Base;
using NewLife.Log;
using Service.impl;
using Service.interfaces;
using Service.Token;
using Service.WinSw;

XTrace.UseConsole();
static WebApplication GetApp()
{
    //��������ԭ�е��߼�
    var args = Environment.GetCommandLineArgs();
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddDbContextFactory<BaseDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration["ConnectionString:DbConn"]);
    });

    // DIע��
    builder.Services.AddSingleton<IRedis, RedisImpl>();
    builder.Services.AddScoped<ITokenHandler, TokenHandler>();
    builder.Services.AddScoped<IUserManagerService, UserService>();
    builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
    builder.Services.AddScoped<IUserManagerRepository, UserManagerRepository>();
    builder.Services.AddScoped<ITaskRunService, TaskRunImplService>();


    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseAuthorization();

    app.MapControllers();

   return app;

}


// ��Ӧ��launchSettings.json ��ASPNETCORE_ENVIRONMENT��ֵ
var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "";

if ("Development".Equals(environment) && args?.Length == 0)
    args = new string[] { "-run" };
new WinAgentService { StartAct = GetApp }.Main(args);
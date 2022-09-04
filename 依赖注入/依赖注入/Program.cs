using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NAutowired;
using NAutowired.Core.Extensions;
using 依赖注入.Logic;

var builder = WebApplication.CreateBuilder(args);


// Add Controllers As Services
builder.Services.AddControllers().AddControllersAsServices();

//注册应用服务
//Replace `IControllerActivator` implement.
builder.Services.Replace(ServiceDescriptor.Transient<IControllerActivator, NAutowiredControllerActivator>());///覆盖掉原先微软 DependencyInjection的一些逻辑
//Add config to ioc container
builder.Services.Configure<SnowflakeConfig>(builder.Configuration.GetSection("Snowflake")); //把字段注入到ioc容器中
//Use auto dependency injection
builder.Services.AutoRegisterDependency(new List<string> { "依赖注入" }); //这里填写的是要被注入模板相关代码的dll名称

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

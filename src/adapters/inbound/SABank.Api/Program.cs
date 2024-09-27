using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SABank.Application.Services;
using NLog;
using NLog.Web;
using SABank.Infra.Context;
using SABank.Infra.repositories;
using SABank.Interfaces.Inbound;
using SABank.Interfaces.Outbound;
using SABank.Api.Middlewares;
using SABank.Infra.Loggers;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    // Add services to the container.
    builder.Services.AddControllers();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "SABank", Description = "Controle Finanças.", Version = "v1" });
    });

    builder.Services.AddScoped<IUserService, UserService>();
    builder.Services.AddScoped<IUserRepository, UserRepository>();
    builder.Services.AddScoped<ILoggerAdapter<GlobalExceptionMiddleware>, LoggerAdapter<GlobalExceptionMiddleware>>();
    builder.Services.AddDbContext<UserContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("pgsql")));
    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

    var app = builder.Build();

    app.UseHttpLogging();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.UseMiddleware<GlobalExceptionMiddleware>();

    app.MapControllers();

    app.Run();
}
catch(Exception ex)
{
    logger.Error(ex);
}
finally
{
    LogManager.Shutdown();
}
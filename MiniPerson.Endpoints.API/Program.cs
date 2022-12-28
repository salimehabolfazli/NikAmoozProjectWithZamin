using MiniPerson.Endpoints.API;
using Zamin.Extensions.DependencyInjection;
using Zamin.Utilities.SerilogRegistration.Extensions;

SerilogExtensions.RunWithSerilogExceptionHandling(() =>
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddCors();
    var app = builder.AddZaminSerilog(c =>
    {
        c.ApplicationName = "MiniPerson";
        c.ServiceName = "MiniPersonService";
        c.ServiceVersion = "1.0";
    }).ConfigureServices().ConfigurePipeline();

    app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader());
    app.Run();
});

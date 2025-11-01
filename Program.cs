using Azure.Identity;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

// Application Insights isn't enabled by default. See https://aka.ms/AAt8mw4.
// builder.Services
//     .AddApplicationInsightsTelemetryWorkerService()
//     .ConfigureFunctionsApplicationInsights();

//var isLocalHost = Environment.GetEnvironmentVariable("");

try
{
    builder.Services.AddSingleton<DefaultAzureCredential>(s =>
    {
        var credential = new DefaultAzureCredential();
        return credential;
    });
    builder.Build().Run();
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}

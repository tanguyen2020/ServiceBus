using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: FunctionsStartup(typeof(FunctionSendMessage.Startup))]
namespace FunctionSendMessage
{
    public class Startup : FunctionsStartup
    {
        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            var context = builder.GetContext();
            var builderSetting = builder.ConfigurationBuilder
                .SetBasePath(context.ApplicationRootPath)
                .AddJsonFile($"appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
            var configuration = builderSetting.Build();
            builderSetting.AddConfiguration(configuration);
        }
        public override void Configure(IFunctionsHostBuilder builder)
        {
            Log.Logger.Information("FunctionsStartup is starting.");
        }
    }
}

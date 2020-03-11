using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System.Collections.Generic;
using System.Text;
using Card_Game.BLL;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Card_Game.ConsoleApp
{
    public class Startup
    {
        public Startup()
        {
        }

        public void Run()
        {
            ConfigureLogging();
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<Controller>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<ICardDeckService, CardDeckService>();
            
            services.AddTransient<Controller>();

            return services;
        }

        public static void ConfigureLogging()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs\\cardGameLogs.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }
    }
}

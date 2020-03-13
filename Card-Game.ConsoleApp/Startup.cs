using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System.Collections.Generic;
using System.Text;
using Card_Game.BLL;
using Microsoft.Extensions.Configuration;
using Serilog;
using Autofac;
using Card_Game.DAL;
using Microsoft.EntityFrameworkCore;

namespace Card_Game.ConsoleApp
{
    public static class Startup
    {
        public static IContainer Configure()
        {
            ConfigureLogging();

            //Configuring Services
            Log.Logger.Information("Starting to configure Services...");
            var builder = new ContainerBuilder();
            builder.RegisterType<Controller>().AsSelf();
            builder.RegisterType<CardDeckService>().As<ICardDeckService>();
            builder.RegisterType<CardDeckRepo>().As<ICardDeckRepo>();
            builder.RegisterType<ConsoleContext>().AsSelf();
            //Instantiating Database
            builder.Register(c =>
            {
                var opt = new DbContextOptionsBuilder<ConsoleContext>();
                opt.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Card-Game-Console;Trusted_Connection=True;MultipleActiveResultSets=true");
                return new ConsoleContext(opt.Options);
            }).AsSelf();

            //Return container with configured Services for using.
            Log.Logger.Information("Service configuration done.");
            return builder.Build();
        }

        public static void ConfigureLogging()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json").SetBasePath("C:/Users/ac.HSGMBH/source/repos/Card-Game/Card-Game.ConsoleApp/")
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                //.WriteTo.File("logs\\cardGameLogs.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Logger.Information("Logger has been initialized");
        }
    }
}

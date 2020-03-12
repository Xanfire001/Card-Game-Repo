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
            builder.RegisterType<Controller>().As<IController>();
            builder.RegisterType<CardDeckService>().As<ICardDeckService>();
            builder.RegisterType<CardDeckRepo>().As<ICardDeckRepo>();

            //Instantiating Database
            builder.Register(c =>
            {
                var opt = new DbContextOptionsBuilder<DatabaseContext>();
                opt.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-Card-Game.ASP-DAEA33CE-8CAF-408B-B1A7-93F83AD60EE2;Trusted_Connection=True;MultipleActiveResultSets=true");
                return new DatabaseContext(opt.Options);
            }).AsSelf();

            //Return container with configured Services for using.
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

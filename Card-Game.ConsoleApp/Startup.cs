using Card_Game.BLL;
using Microsoft.Extensions.Configuration;
using Serilog;
using Autofac;
using Card_Game.DAL;
using Microsoft.EntityFrameworkCore;
using Card_Game.ConsoleApp.Views;

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
            builder.RegisterType<CardService>().As<ICardService>();
            builder.RegisterType<CardRepo>().As<ICardRepo>();
            builder.RegisterType<CardDeckService>().As<ICardDeckService>();
            builder.RegisterType<CardDeckRepo>().As<ICardDeckRepo>();
            builder.RegisterType<ConsoleContext>().AsSelf();
            builder.RegisterType<Ui>().AsSelf();
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
            Log.Logger.Information("Initializing Logger");
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json").SetBasePath("C:/Users/alexw/source/repos/Card-Game-Repo/Card-Game.ConsoleApp/")
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .WriteTo.File("logs\\cardGameLogs.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Logger.Information("Logger has been initialized");
        }
    }
}

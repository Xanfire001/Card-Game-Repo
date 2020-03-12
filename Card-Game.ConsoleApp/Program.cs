using Card_Game.BLL;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using Autofac;

namespace Card_Game.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var container = Startup.Configure();
                Log.Logger.Information("Service configuration done.");
                Log.Logger.Information("Starting application...");
                using (var scope = container.BeginLifetimeScope())
                {
                    var app = scope.Resolve<IController>();
                    app.Run();
                }
            }
            catch(Exception ex)
            {
                Log.Logger.Fatal(ex, "Application failed to start correctly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
            Console.ReadLine();
        }

        

        
    }
}
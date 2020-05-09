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
                Log.Logger.Information("Starting application...");
                using (var scope = container.BeginLifetimeScope())
                {
                    var app = scope.Resolve<Controller>();
                    try
                    {
                        app.Run();
                    }
                    catch (Exception ex)
                    {
                        Log.Logger.Fatal(ex, "Application crashed");
                    }
                }
            }
            catch(Exception ex)
            {
                Log.Logger.Fatal(ex, "Application failed to start correctly.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
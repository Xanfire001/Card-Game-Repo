using Card_Game.BLL;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using System;

namespace Card_Game.ConsoleApp
{
    public class Program
    {
        public static Startup Startup = new Startup();
        static void Main(string[] args)
        {
            Startup.Run();
        }

        

        
    }
}
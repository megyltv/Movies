using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace MoviesSearch
{
    public class Program
    {
        public static void Main(string[] args)        {            BuildWebHost(args).Run();        }        public static IWebHost BuildWebHost(string[] args) =>            WebHost.CreateDefaultBuilder(args)            .ConfigureLogging((hostingContext, logging) =>
            {                logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));                logging.AddConsole();                logging.AddDebug();                logging.AddEventSourceLogger();                logging.AddNLog();            })            .UseKestrel()            .UseContentRoot(Directory.GetCurrentDirectory())            .UseIISIntegration()            .UseStartup<Startup>()            .Build();    }
}

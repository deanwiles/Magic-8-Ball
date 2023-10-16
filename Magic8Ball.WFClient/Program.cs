using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Magic8Ball.WFClient
{
    internal static class Program
    {
        public static IConfiguration? Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To register all default providers:
            var host = Host.CreateDefaultBuilder(args).Build();
            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
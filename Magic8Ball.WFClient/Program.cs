using Microsoft.Extensions.Configuration;

namespace Magic8Ball.WFClient
{
    internal static class Program
    {
        public static IConfiguration? Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To register all default providers:
            string? environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT"); ;
            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
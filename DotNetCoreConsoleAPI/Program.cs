using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace DotNetCoreConsoleAPI
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                CreateWebHostBuilder(args).Build().Run();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
            ;

    }
}

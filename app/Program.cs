// using System.Linq;
// using System.Threading.Tasks;

using System;                     
using System.IO;                            
using System.Collections.Generic;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables("")
            .Build();

            var url = config["ASPNETCORE_URLS"] ?? "http://*:8080";

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls(url)
                .Build();

            host.Run();
        }
    }
}

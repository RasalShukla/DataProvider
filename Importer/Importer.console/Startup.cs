using Importer.BusinessManager;
using Importer.persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Importer.console
{
    public static class Startup
    {
        public static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();
            

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);
            IConfiguration configuration = builder.Build();
            services.AddApplication();
             services.AddInfrastructure(configuration);
            services.AddSingleton(configuration);

            

          

            return services;
        }
    }
}

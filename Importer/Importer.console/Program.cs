using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Importer.console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = Startup.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            await serviceProvider.GetService<EntryPoint>().Run(args);
        }
    }
}

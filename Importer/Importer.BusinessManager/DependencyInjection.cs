using AutoMapper;
using Importer.BusinessManager.Contracts;
using Importer.BusinessManager.Implementations;
using Importer.BusinessManager.Imports.ImportStrategies;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


namespace Importer.BusinessManager
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // To DO In Future We can register Auto mapper here 
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<ICsvReader,CsvReader>();
            services.AddTransient<IDownloadFile, DownloadFile>();
            services.AddTransient<IFileReader, FileReader>();
            services.AddTransient<IImport, Import>();
            services.AddTransient<IImportStrategy, CapterraImportStrategy>();
            services.AddTransient<IImportStrategy, GartnerImportStrategy>();
            services.AddTransient<IImportStrategy, SoftwareadviceImportStrategy>();
            return services;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using Importer.persistence.MySql;
using Importer.persistence.MongoDb;

namespace Importer.persistence
{
    public class DatabaseSettings
    {
        public string DatabaseType { get; set; }
    }
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var databaseSection = configuration.GetSection("Database");
           //services.Configure<DatabaseSettings>(databaseSection);
            var databaseSettings = databaseSection.Get<DatabaseSettings>();
            switch (databaseSettings.DatabaseType)
            {
                case "MySQL":
                    var sqlConnectionString = configuration.GetConnectionString("DataAccessMySqlProvider");
                    services.AddDbContext<DomainModelMySqlContext>(options =>
                    options.UseMySql(sqlConnectionString, b => b.MigrationsAssembly("Importer.web")));
                    services.AddScoped<IDataAccessProvider, DataAccessMySqlProvider>();
                    break;
                case "MongoDb":
                    services.AddSingleton<IMongoClient>(s => new MongoClient(configuration.GetConnectionString("MongoDb")));
                    services.AddScoped(s => new DomainModelMongoDbContext(s.GetRequiredService<IMongoClient>(), configuration["MongoDbName"]));
                    services.AddScoped<IDataAccessProvider, DataAccessMySqlProvider>();
                    break;
                default:
                    throw new Exception("UnExpected Db;");
            }
            return services;
        }
    }
}

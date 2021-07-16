using Importer.persistence.Entities;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Importer.persistence.MongoDb
{
    public class DomainModelMongoDbContext : DbContext
    {
        private readonly IMongoDatabase _db;

        public DomainModelMongoDbContext(IMongoClient client, string dbName)
        {
            _db = client.GetDatabase(dbName);
        }

        public IMongoCollection<ImportEntityModel> Imports => _db.GetCollection<ImportEntityModel>("imports");
    }
}

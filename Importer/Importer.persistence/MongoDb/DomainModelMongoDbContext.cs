using Importer.persistence.Entities;
using Importer.persistence.Entities.MongoCollection;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Importer.persistence.MongoDb
{
    public class DomainModelMongoDbContext 
    {
        private readonly IMongoDatabase _db;

        public DomainModelMongoDbContext(IMongoClient client, string dbName)
        {
            _db = client.GetDatabase(dbName);
        }

        public IMongoCollection<ImportEntityMongoModel> Imports => _db.GetCollection<ImportEntityMongoModel>("imports");
    }
}

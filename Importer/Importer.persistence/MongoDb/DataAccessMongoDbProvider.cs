using Importer.persistence.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.persistence.MongoDb
{
    public class DataAccessMongoDbProvider : IDataAccessProvider
    {
        private readonly DomainModelMongoDbContext _db;
        public DataAccessMongoDbProvider(DomainModelMongoDbContext db)
        {
            _db = db;
        }
        public async Task AddImportEntityRecordAsync(ImportEntityModel importEntityModel)
        {
          
            // Here We can write one converter which will convert Normal Entity Model To Mongo model
            await _db.Imports.InsertOneAsync(importEntityModel);
        }

       
    }
}

using Importer.persistence.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.persistence.MySql
{
    public class DataAccessMySqlProvider : IDataAccessProvider
    {
        private readonly DomainModelMySqlContext _context;
        public DataAccessMySqlProvider(DomainModelMySqlContext context)
        {
            _context = context;
        }

        public async Task AddImportEntityRecordAsync(ImportEntityModel importEntityModel)
        {
            _context.ImportEntityRecords.Add(importEntityModel);
            await _context.SaveChangesAsync();
        }
    }
}

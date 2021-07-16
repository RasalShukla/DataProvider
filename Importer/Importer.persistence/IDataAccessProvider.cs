using Importer.persistence.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.persistence
{
    public interface IDataAccessProvider
    {
        Task AddImportEntityRecordAsync(ImportEntityModel importEntityModel); 
    }
}

using AutoMapper;
using Importer.BusinessManager.Contracts;
using Importer.model.Models;
using Importer.persistence;
using Importer.persistence.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.BusinessManager.Implementations
{
    public class ImportOperationDataAccess : IImportOperationDataAccess
    {
        private readonly IDataAccessProvider dataAccessProvider;
  
        public ImportOperationDataAccess(IDataAccessProvider dataAccessProvider)
        {
            this.dataAccessProvider = dataAccessProvider;
           
        }
        public async Task SaveImportDataInDb(DataBaseModel dataBaseModel)
        {
            // Call Auto Mapper Convert model to expected model
            ImportEntityModel importEntityModel = new ImportEntityModel();
            await dataAccessProvider.AddImportEntityRecordAsync(importEntityModel);
        }
    }
}

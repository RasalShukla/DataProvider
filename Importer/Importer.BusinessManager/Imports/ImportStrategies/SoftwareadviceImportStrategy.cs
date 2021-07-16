using Importer.BusinessManager.Contracts;
using Importer.model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.BusinessManager.Imports.ImportStrategies
{
    public class SoftwareadviceImportStrategy : IImportStrategy
    {
        public async Task ImportAsync(ImportModel importModels)
        {
            // To do write actual code 
             await Task.FromResult(new DataBaseModel());
        }
    }
}

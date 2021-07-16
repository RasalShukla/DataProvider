using Importer.BusinessManager.Contracts;
using Importer.model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.BusinessManager.Implementations
{
    public class CsvReader : ICsvReader
    {
        public async Task<DataBaseModel> ReadCsvData(string csvPath)
        {
            // To DO Read Data From csv Path and  return DataBaseModelResponse
            return await Task.FromResult(new DataBaseModel());
        }
    }
}

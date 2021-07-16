using Importer.BusinessManager.Contracts;
using Importer.common;
using Importer.common.Enums;
using Importer.model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.BusinessManager.Implementations
{
    public class FileReader : IFileReader
    {
        private readonly ICsvReader csvReader;
        public FileReader(ICsvReader csvReader)
        {
            this.csvReader = csvReader;
        }
        public async Task<DataBaseModel> Read(string filePath, FileType fileType)
        {
            switch (fileType)
            {
                case FileType.CSV:
                  return await csvReader.ReadCsvData(filePath);
                default:
                    throw new Exception("Invalid File Type.");
            }
        }
    }
}

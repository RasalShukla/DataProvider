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
       
        private readonly IImportOperationDataAccess importOperationDataAccess;
        public FileReader(IImportOperationDataAccess importOperationDataAccess)
        {
            this.importOperationDataAccess = importOperationDataAccess;
        }
        public async Task Read(string filePath, FileType fileType)
        {
            switch (fileType)
            {
                case FileType.CSV:

                    //Step 1- Read CSV line by line 

                    //Step 2 - Use AutoMapper to convert source data model to destination data model

                    //Step 3- and Bulk insert in DB 
                    DataBaseModel dataBaseModel = new DataBaseModel();
                    await importOperationDataAccess.SaveImportDataInDb(dataBaseModel);
                    break;
                default:
                    throw new Exception("Invalid File Type.");
            }
        }
    }
}

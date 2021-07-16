using Importer.BusinessManager.Contracts;
using Importer.model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.BusinessManager.Imports.ImportStrategies
{
    public class GartnerImportStrategy : IImportStrategy
    {
        private readonly IDownloadFile download;
        private readonly IFileReader fileReader;
        public GartnerImportStrategy(IDownloadFile download, IFileReader fileReader)
        {
            this.download = download;
            this.fileReader = fileReader;
        }
        public async Task ImportAsync(ImportModel importModels)
        {
            // Download file 
           await download.DownloadFileAsync(importModels.GartnerImportModel.DownloadUrl);
            // 
           await fileReader.Read("download file path", importModels.GartnerImportModel.FileType);
        }
    }
}

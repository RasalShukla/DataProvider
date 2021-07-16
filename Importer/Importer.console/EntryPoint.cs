using Importer.BusinessManager.Contracts;
using Importer.model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Importer.common.Enums;

namespace Importer.console
{
    public class EntryPoint
    {
        private readonly IImport import;
        public EntryPoint(IImport import)
        {
            this.import = import;
        }
        public async Task Run(String[] args)
        {
            await Task.Run(async () =>
            {
                List<ImportModel> importModels = new List<ImportModel>();
                GartnerImportModel gartnerImportModel = new GartnerImportModel { DownloadUrl = "Pick this url from Appsetting.json", FileType = FileType.CSV };
                SoftwareadviceImportModel softwareadviceImportModel = new SoftwareadviceImportModel { };
                CapterraImportModel capterraImportModel = new CapterraImportModel { };
                importModels.Add(new ImportModel { SoftwareadviceImportModel = softwareadviceImportModel, ImportSource = ImportSource.Softwareadvice });
                importModels.Add(new ImportModel { CapterraImportModel = capterraImportModel, ImportSource = ImportSource.Capterra });
                importModels.Add(new ImportModel { GartnerImportModel = gartnerImportModel, ImportSource = ImportSource.Gartner });
                await import.ImportSourceDatatAsync(importModels);
            });
           
        }
    }
}

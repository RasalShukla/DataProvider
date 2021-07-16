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
            var gartner = new GartnerImportModel()
            {
                DownloadUrl = "", 
                FileType =FileType.CSV
            };
            ImportModel importModel = new ImportModel(gartner);

           await import.ImportSourceDatatAsync(importModel);
        }
    }
}

using Importer.BusinessManager.Contracts;
using Importer.BusinessManager.Imports.ImportStrategies;
using Importer.common;
using Importer.common.Enums;
using Importer.model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Importer.BusinessManager.Implementations
{
    public class Import : IImport
    {
        private readonly IFileReader fileReader;                                                                                                                                                                                                  
        private readonly IDownloadFile download;

        public Import (IFileReader fileReader, IDownloadFile download)
        {
            this.fileReader = fileReader;
            this.download = download;
        }
        public async Task ImportSourceDatatAsync(IList<ImportModel> importModel)
        {
            try
            {
                foreach (var item in importModel)
                {
                    switch (item.ImportSource)
                    {
                        case ImportSource.Capterra:
                            ImportStrategyClient capterraClient = new ImportStrategyClient(new CapterraImportStrategy());
                            await capterraClient.ImportAsync(item).ConfigureAwait(false);
                            break;

                        case ImportSource.Softwareadvice:
                            ImportStrategyClient softwareadviceClient = new ImportStrategyClient(new SoftwareadviceImportStrategy());
                            await softwareadviceClient.ImportAsync(item).ConfigureAwait(false);
                            break;

                        case ImportSource.Gartner:
                            ImportStrategyClient gartnerClient = new ImportStrategyClient(new GartnerImportStrategy(download, fileReader));
                            await gartnerClient.ImportAsync(item).ConfigureAwait(false);
                            break;
                    }
                }   
            }
            catch
            {
               throw;
            }
            
        }
    }
}

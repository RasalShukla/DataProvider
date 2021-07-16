using Importer.BusinessManager.Contracts;
using Importer.model.Models;
using System.Threading.Tasks;

namespace Importer.BusinessManager.Imports.ImportStrategies
{
    public class ImportStrategyClient
    {
        private readonly IImportStrategy importStrategy;
        public ImportStrategyClient(IImportStrategy strategy)
        {
            importStrategy = strategy;
        }

        //Executes the strategy  
        public async Task ImportAsync(ImportModel importModel)
        {
           await importStrategy.ImportAsync(importModel).ConfigureAwait(false);
        }
    }
}

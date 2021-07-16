using Importer.model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.BusinessManager.Contracts
{
    public interface IImportStrategy
    {
        Task ImportAsync(ImportModel importModels);
    }
}

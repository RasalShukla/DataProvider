using Importer.common;
using Importer.common.Enums;
using Importer.model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.BusinessManager.Contracts
{
    public interface IFileReader
    {
        Task<DataBaseModel> Read(string filePath, FileType fileType);
    }
}

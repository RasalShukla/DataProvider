using Importer.BusinessManager.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.BusinessManager.Implementations
{
    public class DownloadFile : IDownloadFile
    {
        public async Task<string>  DownloadFileAsync(string url)
        {
            // To do write the download file logic 
            return await Task.FromResult("download file Path");
        }
    }
}

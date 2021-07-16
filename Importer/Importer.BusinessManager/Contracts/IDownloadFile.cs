using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Importer.BusinessManager.Contracts
{
    public interface IDownloadFile
    {
        Task DownloadFileAsync(string url);
    }
}

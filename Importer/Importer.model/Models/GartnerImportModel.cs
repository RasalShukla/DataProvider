using Importer.common;
using Importer.common.Enums;

namespace Importer.model.Models
{
    public class GartnerImportModel
    {
        public string DownloadUrl { get; set; }

        public FileType FileType { get; set; }
    }
}
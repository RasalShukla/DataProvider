using Importer.common;
using Importer.common.Enums;

namespace Importer.model.Models
{
    public class ImportModel
    {
        public ImportModel()
        {
            if(CapterraImportModel == null)
            {
                CapterraImportModel = new CapterraImportModel();
            }
            if (SoftwareadviceImportModel == null)
            {
                SoftwareadviceImportModel = new SoftwareadviceImportModel();
            }
            if (GartnerImportModel == null)
            {
                GartnerImportModel = new GartnerImportModel();
            }
        }
        public CapterraImportModel CapterraImportModel { get; set; }
        public SoftwareadviceImportModel SoftwareadviceImportModel { get; set; }
        public GartnerImportModel GartnerImportModel { get; set; }
        public ImportSource ImportSource { get; set; }

    }
}


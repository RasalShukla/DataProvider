using Importer.common;
using Importer.common.Enums;

namespace Importer.model.Models
{
    public class ImportModel
    {
        public ImportModel()
        {
        }

        public ImportModel(CapterraImportModel capterraImportModel)
        {
            CapterraImportModel = capterraImportModel;
            ImportSource = ImportSource.Capterra;
        }

        public ImportModel(SoftwareadviceImportModel softwareadviceImportModel)
        {
            SoftwareadviceImportModel = softwareadviceImportModel;
            ImportSource = ImportSource.Softwareadvice;
        }

        public ImportModel(GartnerImportModel gartnerImportModel)
        {
            GartnerImportModel = gartnerImportModel;
            ImportSource = ImportSource.Gartner;
        }
        public CapterraImportModel CapterraImportModel { get; set; }
        public SoftwareadviceImportModel SoftwareadviceImportModel { get; set; }
        public GartnerImportModel GartnerImportModel { get; set; }
        public ImportSource ImportSource { get; set; }

    }
}


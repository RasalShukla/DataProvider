using Importer.BusinessManager.Contracts;
using Importer.model.Models;
using Moq;
using System;
using Xunit;

namespace importer.tests
{
    public class CsvReaderTest
    {
        private Mock<ICsvReader> _mockCsvReader;
        private const string csvPath = "www.goole.com";
        public CsvReaderTest()
        {
            _mockCsvReader = new Mock<ICsvReader>();
        }

        [Fact]
        public async void Should_Retrun_DatabaseModel_Object()
        {
            var result = await _mockCsvReader.Object.ReadCsvData(csvPath);
            Assert.IsAssignableFrom<DataBaseModel>(result);
        
        }
    }
}

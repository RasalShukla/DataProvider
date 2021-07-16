using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Importer.BusinessManager.Contracts;
using Importer.common.Enums;
using Importer.model.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Importer.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IImport import;
       

        public WeatherForecastController(IImport import)
        {
            this.import = import;
            var gartner = new GartnerImportModel()
            {
                DownloadUrl = "",
                FileType = FileType.CSV
            };
            ImportModel importModel = new ImportModel(gartner);

             import.ImportSourceDatatAsync(importModel);
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}

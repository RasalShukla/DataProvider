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
       
        }

        
    }
}

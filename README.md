Step to use import library:- 

I have added 3rd data provider with The Name of -Gartner

My Development Env - Windows 10, 
IDE - Visual Studio 2019

Installation Step  

This project is developed in .Net Core 3.1

Please follow below URL to install .Net core in your system -
https://dotnet.microsoft.com/download/dotnet/3.1

Take pull of code, unzip the folder, and open it in visual studio code.
Set Importer.Console as startup project, and run the application.

Steps to integrate class library in any Dot net core project:-

Now I am assuming want to use this library on web application 

Step 1 - Add Reference of below project
         Importer.BusinessManager
         Importer.common
         Importer.persistence
         Importer.model

Step 2 - Add below keys in AppSettings.json
            "ConnectionStrings": {
            "DataAccessMySqlProvider": "server=localhost;userid=damienbod;password=1234;database=nlog;",
            "MongoDb": "mongodb://localhost:27017"
            },
            "Database": { "DatabaseType": "MySQL" },  //  By Default Code Is Running With MySql // Replace MySQL to MongoDb 
            "MongoDbName": "Imports",

Step 3 - In Strtup.cs file Add below dependencies 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication(); // register Business Manager DI
            services.AddInfrastructure(Configuration);   // register DB DI
        }

Step 4- Create an Web Api controller (I am assuming Web Project is webApi)
       For Ex - Import Controller
       private readonly IImport import;
        public ImportController(IImport import)
        {
            this.import = import;
        }

        [HttpGet]
        [Route("ImportData")]
        [HttpGet]
        public async Task<IHttpActionResult> ImportData(string edcode)
        {
           
                List<ImportModel> importModels = new List<ImportModel>();
                GartnerImportModel gartnerImportModel = new GartnerImportModel { DownloadUrl = "Pick this url from Appsetting.json", FileType = FileType.CSV };
                SoftwareadviceImportModel softwareadviceImportModel = new SoftwareadviceImportModel { };
                CapterraImportModel capterraImportModel = new CapterraImportModel { };
                importModels.Add(new ImportModel { SoftwareadviceImportModel = softwareadviceImportModel, ImportSource = ImportSource.Softwareadvice });
                importModels.Add(new ImportModel { CapterraImportModel = capterraImportModel, ImportSource = ImportSource.Capterra });
                importModels.Add(new ImportModel { GartnerImportModel = gartnerImportModel, ImportSource = ImportSource.Gartner });
                await import.ImportSourceDatatAsync(importModels);
                return Ok();  
        } 
       
Step 5 - Run the API

STEP 6 - Enjoy Your Code.

Where to Find My Code -

Code is available onbelow url 
https://github.com/RasalShukla/DataProvider

Was it your first time writing a unit test, using a particular framework, etc?

No, But Due to lack of time I have added only one test case (Very small).

What would you have done differently if you had had more time?

1 - Add Logger 
2 - Add Auto Mapper 
3 - Add Different Type of Exception Class for different type of exception 
4 - Add Validation Logic to Validate Input Data
5 - Currently I have tried to Manage Mongo and My Sql with one project, but for better layering, it should be in different-different project.
6 - On running Task we can set up long running task.
7 - Add Key-Vault to keep all the secure information i.e connection string



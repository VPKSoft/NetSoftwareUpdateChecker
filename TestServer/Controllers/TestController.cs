using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using NetSoftwareUpdateChecker;
using Newtonsoft.Json;

namespace TestServer.Controllers
{
    public class TestController: Controller
    {
        [Route("api/test")]
        [HttpGet]
        public IEnumerable<UpdateData> GetTestData()
        {
            return SampleDataProvider.SampleData;
        }

        [Route("api/download/{fileName}")]
        public IActionResult DownloadJsonFile(string fileName)
        {
            var fileContents = JsonConvert.SerializeObject(SampleDataProvider.SampleData);

            return File(Encoding.UTF8.GetBytes(fileContents), "application/octet-stream", fileName);
        }
    }
}

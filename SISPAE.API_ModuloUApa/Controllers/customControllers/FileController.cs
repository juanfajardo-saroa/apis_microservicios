using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SISPAE.Business.Services;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.OData.Query; using ElmahCore;
using Microsoft.AspNetCore.Authorization;

namespace SISPAE.WebAPI.Controllers
{
    [SwaggerTag("Web API para CRUD de AccionesMejora .")]
    [Route("api/[controller]/[Action]")]
    [ApiController] 

    public class FileController : ControllerBase
    {
        private IBlobStorageService _blobStorageService;
        private readonly IConfiguration _configuration;
        private readonly string _cnx;
        private readonly string _container;

        public FileController(IBlobStorageService blobStorageService, IConfiguration configuration)
        {
            _blobStorageService = blobStorageService;
            _configuration = configuration;
            _cnx = _configuration.GetValue<string>("blobstorage:cnx");
            _container = _configuration.GetValue<string>("blobstorage:container");
        }

        [HttpGet]
        [EnableQuery()]
        [Authorize]
        //[Route("download/{fileName}")]
        public async Task<IActionResult> DownloadAsync(string fileName)
        {
            var file = await _blobStorageService.GetBlobAsync(fileName, _container, _cnx);
            return File(file.Content, "application/octet-stream", fileName);
        }


        [HttpPut]
        [EnableQuery()]
        [Authorize]
        public async Task<string> UploadAsync(IFormFile file, string fileName)
        {
            string r = await _blobStorageService.UploadFileToBlobAsync(file, _cnx, fileName, _container);

            return r;

        }

      

    }
}

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

        public FileController(IBlobStorageService blobStorageService)
        {
            _blobStorageService = blobStorageService;
        }

        [HttpGet]
        [EnableQuery()]
        [Authorize]
        //[Route("download/{fileName}")]
        public async Task<IActionResult> DownloadAsync(string fileName, string Container, string cnx)
        {
            var file = await _blobStorageService.GetBlobAsync(fileName, Container, cnx);

            return File(file.Content, "application/octet-stream", fileName);
        }


        [HttpPut]
        [EnableQuery()]
        [Authorize]
        public async Task<string> UploadAsync(IFormFile file, string cnx, string fileName, string Container)
        {
            string r = await _blobStorageService.UploadFileToBlobAsync(file, cnx, fileName, Container);
            return r;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http.Headers;
using TransportWebAPI.Controllers.Upload;
using Microsoft.AspNetCore.StaticFiles;
using DBLayerPOC.Infrastructure.UploadDownload;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private UploadDirectoryService _uploadDirectoryService;
        private IEmailSendingClient _emailSendingClient;

        public UploadController(UploadDirectoryService uploadDirectoryService, EmailSendingClient emailSendingClient)
        {
            _uploadDirectoryService = uploadDirectoryService;
            
            _emailSendingClient = emailSendingClient;
        }

        //POST - Upload
        [HttpPost]
        public IActionResult Upload(int? documentId, string fileExtension, string discriminator, bool overwriteExiting)
        {
            try
            {
                var file = Request.Form.Files[0];
                if (file.Length > 0)
                {
                    if (!overwriteExiting)
                    {
                        var fileAlreadyUploaded = _uploadDirectoryService.ExistFileWithSameFileNameForTheDocument(discriminator, documentId, fileName, fileExtension);
                        if (fileAlreadyUploaded)
                        {
                            return StatusCode(StatusCodes.Status302Found);
                        }
                    }
                    var fileMetadata = new FileMetadata
                    {
                        FileName = fileName,
                        Discriminator = discriminator, 
                        DocumentId = documentId,
                        Extension = fileExtension
                    };
                    var fullPath = _uploadDirectoryService.FileUpload(file, fileMetadata);
                    return Ok(new { fullPath });

                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                _emailSendingClient.SendLogEmail(ex.Message);
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        ////GET - Download
        //[HttpGet]
        //public IActionResult Download()
        //{
        //    var filePath = Path.Combine(_pathToSave, "ausmalbild-hase-mit-m-re-aiquruguay.pdf");
        //    var bytes = System.IO.File.ReadAllBytes(filePath);
        //    var provider = new FileExtensionContentTypeProvider();
        //    if (!provider.TryGetContentType(filePath, out var contentType))
        //    {
        //        contentType = "application/octet-stream";
        //    }
        //    return File(bytes, contentType, Path.GetFileName(filePath));
        //}

        //// GET: api/Upload
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Upload/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Upload
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Upload/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

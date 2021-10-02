using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http.Headers;
using TransportWebAPI.Controllers.Upload;
using System.Text.Json;
using System.Text.Json.Serialization;
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
       // public IActionResult Upload(int? documentId, string fileExtension, string discriminator, bool overwriteExiting, string fileName)
        public IActionResult Upload([FromForm] FileMetadata fileMetadataParam)
        {
            try
            {
                
                var file = Request.Form.Files[0];
                var fileMetadataJson = Request.Form["metadata"][0];
                var fileMetadata = JsonSerializer.Deserialize<FileMetadata>(fileMetadataJson);
                if (file.Length > 0)
                {
                    if (!fileMetadata.OverwriteExisting)
                    {
                        var fileAlreadyUploaded = _uploadDirectoryService
                            .ExistFileWithSameFileNameForTheDocument(file, fileMetadata);
                        if (fileAlreadyUploaded)
                        {
                            return StatusCode(StatusCodes.Status302Found);
                        }
                    }

                    var fullPath = _uploadDirectoryService.FileUpload(file, fileMetadata);
                    return Ok(fullPath);

                }
                //else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                _emailSendingClient.SendLogEmail("Upload error" + " - " + ex.Message);
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        //GET - Download
        [HttpGet, DisableRequestSizeLimit]
        public IActionResult Download(int? documentId, string fileExtension, string discriminator, string fileName)
        {
            try
            {
                var fileMetadata = _uploadDirectoryService.SelectFileMetadataFromDatabase(discriminator, documentId, fileName, fileExtension);
                var filePath = fileMetadata.FilePath;
                var bytes = System.IO.File.ReadAllBytes(filePath);
                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(filePath, out var contentType))
                {
                    contentType = "application/octet-stream";
                }

                return File(bytes, contentType, Path.GetFileName(fileMetadata.FileName));
            }
            catch(Exception ex)
            {
                _emailSendingClient.SendLogEmail("Upload error" + " - " + ex.Message);
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete(int? documentId, string fileExtension, string discriminator, string fileName)
        {
            try
            {
                _uploadDirectoryService.DeleteUploadedFileFromDatabaseAndHardDrive(discriminator, documentId, fileName, fileExtension);
                return Ok(fileName);
            }
            catch(Exception ex)
            {
                _emailSendingClient.SendLogEmail("Delete error" + " - " + ex.Message);
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

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
    }
}

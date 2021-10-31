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
using Service.Data;
using DBLayerPOC.Infrastructure;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private UploadDirectoryService _uploadDirectoryService;
        private IEmailSendingClient _emailSendingClient;

        public UploadController(EmailSendingClient emailSendingClient, IUnitOfWork<AppDbContext> unitOfWork)
        {
            _uploadDirectoryService = new UploadDirectoryService(emailSendingClient, unitOfWork);
            
            _emailSendingClient = emailSendingClient;
        }

        [HttpPost]
        public IActionResult Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileMetadataJson = Request.Form["metadata"][0];
                var fileMetadata = JsonSerializer.Deserialize<FileMetadata>(fileMetadataJson);
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                fileMetadata.FileName = fileName;
                var fileExtension = Path.GetExtension(file.FileName);
                fileMetadata.Extension = fileExtension;
                if (!_uploadDirectoryService.IsFileExtensionAllowedForUpload(fileExtension))
                {
                    return StatusCode(501, $"File extension not supported: {fileExtension}");
                }
                if (file.Length > 0)
                {
                    if (!fileMetadata.OverwriteExisting)
                    {
                        var fileAlreadyUploaded = _uploadDirectoryService
                            .ExistFileWithSameFileNameAndExtensionForTheDocument(fileMetadata);
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

        [HttpGet, DisableRequestSizeLimit]
        public IActionResult Download([FromBody] FileMetadata fileMetadata)
        {
            try
            {
                var fileMetadataFromDb = _uploadDirectoryService.SelectFileMetadataFromDatabase(fileMetadata.Discriminator, fileMetadata.DocumentId, fileMetadata.FileName, fileMetadata.Extension);
                //if File is not found in the database
                if(fileMetadataFromDb == null)
                {
                    return StatusCode(404, $"File not found: {fileMetadata.FileName}");
                }
                var filePath = fileMetadataFromDb.FilePath;
                var bytes = System.IO.File.ReadAllBytes(filePath);
                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(filePath, out var contentType))
                {
                    contentType = "application/octet-stream";
                }

                return File(bytes, contentType, Path.GetFileName(fileMetadataFromDb.FileName));
            }
            catch(Exception ex)
            {
                _emailSendingClient.SendLogEmail("Upload error" + " - " + ex.Message);
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
      
        [HttpDelete]
        public IActionResult Delete([FromBody]FileMetadata fileMetadata)
        {
            try
            {
                if (_uploadDirectoryService.ExistFileWithSameFileNameAndExtensionForTheDocument(fileMetadata))
                {
                    _uploadDirectoryService.DeleteUploadedFileFromDatabaseAndHardDrive(fileMetadata.Discriminator, fileMetadata.DocumentId, fileMetadata.FileName, fileMetadata.Extension);
                    return Ok(fileMetadata.FileName);
                }
                else return StatusCode(404, $"File not found: {fileMetadata.FileName}");

            }
            catch(Exception ex)
            {
                _emailSendingClient.SendLogEmail("Delete error" + " - " + ex.Message);
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult GetUploadedFiles([FromBody] FileMetadata fileMetadata)
        {
            try
            {
                var metadataList = _uploadDirectoryService.ReturnListOfMetadataForDocument(fileMetadata.Discriminator, fileMetadata.DocumentId);
                return Ok(metadataList);
            }
            catch (Exception ex)
            {
                _emailSendingClient.SendLogEmail("GetUploadedFiles error" + " - " + ex.Message);
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}

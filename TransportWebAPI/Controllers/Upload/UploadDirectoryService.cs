using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.Settings;
using DBLayerPOC.Infrastructure.UploadDownload;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;


namespace TransportWebAPI.Controllers.Upload
{
    public class UploadDirectoryService
    {
        private readonly AppDbContext _ctx;
        private EmailSendingClient _emailSendingClient;
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public UploadDirectoryService(AppDbContext ctx, EmailSendingClient emailSendingClient, IUnitOfWork<AppDbContext> unitOfWork)
        {
            _ctx = ctx;
            _emailSendingClient = emailSendingClient;           
        }

        public string FileUpload(IFormFile file)
        {
            string nameOfUploadedFile = string.Empty;
            var pathToSave = ReadFolderPathFromSettingsDatatable();
            if (file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                nameOfUploadedFile = Path.Combine(pathToSave, fileName);

                using (var stream = new FileStream(nameOfUploadedFile, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }

            return nameOfUploadedFile;
        }

        private void SaveFileUploadEntryToTheDatabase()
        {

        }

        public bool ExistFileWithSameFileNameForTheDocument(string discriminator, int? documentId, string fileName)
        {
            return _unitOfWork.GetRepository<UploadDownload>().Single(x => x.Discriminator.Equals(discriminator) && x.DocumentId == documentId
            && x.FileName.Equals(fileName)) != default(UploadDownload);
        }

        private void InsertUploadedFileMetadataToDatabase(UploadDownload fileMetadata)
        {
            _unitOfWork.GetRepository<UploadDownload>().Add(fileMetadata);
            _unitOfWork.SaveChanges();
        }

        private string GenerateRandomFileName(string fileName)
        {
            return new Guid(fileName).ToString();
        }

        public string ReadFolderPathFromSettingsDatatable()
        {
            string folderName = string.Empty;
            if (_ctx.SettingsTable.Any(x => x.ObjectName.Equals(Constants.FileUploadFolderPath)))
            {
                folderName = _ctx.SettingsTable.Single(x => x.ObjectName.Equals(Constants.FileUploadFolderPath)).Prefix;
            }

            return folderName;
        }

        public void CreateSettingsDatabaseEntryForFolderPathIfNotExists()
        {
            try
            {
                //First save Upload Folder Path in Settings table if not exist
                if (!_ctx.SettingsTable.Any(x => x.ObjectName.Equals(Constants.FileUploadFolderPath)))
                {
                    string uploadFolderName = "Upload";
                    var currentDirectory = Directory.GetCurrentDirectory();
                    var pathToSave = Path.Combine(Directory.GetParent(currentDirectory).FullName, uploadFolderName);
                    var settings = new Settings
                    {
                        ObjectName = Constants.FileUploadFolderPath,
                        Prefix = pathToSave
                    };

                    _ctx.SettingsTable.Add(settings);

                    _ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                _emailSendingClient.SendLogEmail(ex.Message);
            }
        }
    }
}

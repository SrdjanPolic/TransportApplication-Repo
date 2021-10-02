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
            _unitOfWork = unitOfWork;
        }

        public string FileUpload(IFormFile file, FileMetadata fileMetadata)
        {
            string fileNameAndPath = string.Empty;
            string fileName = string.Empty;
            string fileExtension = string.Empty;
            var randomFileName = Path.GetRandomFileName();
            try
            {
                var pathToSave = ReadFolderPathFromSettingsDatatable();
                if (file.Length > 0)
                {
                    fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    fileExtension = Path.GetExtension(fileName);
                    fileNameAndPath = Path.Combine(pathToSave, randomFileName + fileExtension);

                    using (var stream = new FileStream(fileNameAndPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    //Save database entry for file metadata
                    fileMetadata.GeneratedFileName = randomFileName;
                    fileMetadata.FileName = fileName;
                    fileMetadata.FilePath = fileNameAndPath;
                    fileMetadata.Extension = fileExtension;
                    InsertUploadedFileMetadataToDatabase(fileMetadata);
                }
            }
            catch (Exception ex)
            {
                _emailSendingClient.SendLogEmail(ex.Message);
                _emailSendingClient.SendLogEmail(string.Format("File upload of file {0} failed.", fileName));
                DeleteUploadedFileFromDatabaseAndHardDrive(fileMetadata.Discriminator, fileMetadata.DocumentId, fileName, fileExtension);
            }

            return fileNameAndPath;
        }

        public void DeleteUploadedFileFromDatabaseAndHardDrive(string discriminator, int? documentId, string fileName, string extension)
        {
            string filePath;
            if (DeleteUploadedFileMetadataFromDatabase(discriminator, documentId, fileName, extension, out filePath))
            {
                File.Delete(filePath);
            }
        }

        private bool DeleteUploadedFileMetadataFromDatabase(string discriminator, int? documentId, string fileName, string extension, out string filePath)
        {
            var fileMetadataToDelete = SelectFileMetadataFromDatabase(discriminator, documentId, fileName, extension);
            
            if (fileMetadataToDelete != default(FileMetadata))
            {
                filePath = fileMetadataToDelete.FilePath;
                _unitOfWork.GetRepository<FileMetadata>().Delete(fileMetadataToDelete);
                _unitOfWork.SaveChanges();
                fileMetadataToDelete = SelectFileMetadataFromDatabase(discriminator, documentId, fileName, extension);
                return fileMetadataToDelete == default(FileMetadata);
            }

            filePath = string.Empty;
            return false;
        }

        public bool ExistFileWithSameFileNameForTheDocument(IFormFile file, FileMetadata fileMetadata)
        {
            if (file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var fileExtension = Path.GetExtension(fileName);
                return _unitOfWork.GetRepository<FileMetadata>().Single(x => x.Discriminator.Equals(fileMetadata.Discriminator) && x.DocumentId == fileMetadata.DocumentId
            && x.FileName.Equals(fileName) && x.Extension.Equals(fileExtension)) != default(FileMetadata);
            }

            return false;
        }

        private void InsertUploadedFileMetadataToDatabase(FileMetadata fileMetadata)
        {
            _unitOfWork.GetRepository<FileMetadata>().Add(fileMetadata);
            _unitOfWork.SaveChanges();
        }

       

        public List<FileMetadata> ReturnListOfMetadataForDocument(string discriminator, int? documentId)
        {
            return _unitOfWork.GetRepository<FileMetadata>()
                .GetList(x => x.Discriminator.Equals(discriminator) && x.DocumentId == documentId).Items.ToList();
        }

        public FileMetadata SelectFileMetadataFromDatabase(string discriminator, int? documentId, string fileName, string extension)
        {
            return _unitOfWork.GetRepository<FileMetadata>().Single(x => x.Discriminator.Equals(discriminator) && x.DocumentId == documentId
            && x.FileName.Equals(fileName) && x.Extension.Equals(extension));
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

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
            var randomFileName = Path.GetRandomFileName();
            try
            {
                var pathToSave = ReadFolderPathFromSettingsDatatable();
                if (file.Length > 0)
                {
                    fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    fileNameAndPath = Path.Combine(pathToSave, randomFileName);

                    using (var stream = new FileStream(fileNameAndPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    //Save database entry for file metadata
                    fileMetadata.GeneratedFileName = randomFileName;
                    fileMetadata.FileName = fileName;
                    fileMetadata.FilePath = fileNameAndPath;
                    InsertUploadedFileMetadataToDatabase(fileMetadata);
                }
            }
            catch (Exception ex)
            {
                _emailSendingClient.SendLogEmail(ex.Message);
                _emailSendingClient.SendLogEmail(string.Format("File upload of file {0} failed.", fileName));
                DeleteUploadedFileFromTheHarddrive(randomFileName);
                DeleteUploadedFileMetadataFromDatabase(fileMetadata.Discriminator, fileMetadata.DocumentId, fileMetadata.FileName, fileMetadata.Extension);
            }

            return fileNameAndPath;
        }

        public void DeleteUploadedFileFromTheHarddrive(string generatedRandomFilename)
        {
            var filePath = _unitOfWork.GetRepository<FileMetadata>().Single(x => x.GeneratedFileName.Equals(generatedRandomFilename)).FilePath;
            File.Delete(filePath);   
        }

        //public void DeleteUploadedFileFromTheHarddrive(string discriminator, string fileName, string extension, int? docuentId)
        //{
        //    var filePath = _unitOfWork.GetRepository<FileMetadata>().Single(x => x.Discriminator.Equals(discriminator) && x.FileName.Equals(fileName)
        //    && x.DocumentI ).FilePath;
        //    File.Delete(filePath);
        //}


        public bool ExistFileWithSameFileNameForTheDocument(string discriminator, int? documentId, string fileName, string extension)
        {
            return _unitOfWork.GetRepository<FileMetadata>().Single(x => x.Discriminator.Equals(discriminator) && x.DocumentId == documentId
            && x.FileName.Equals(fileName) && x.Extension.Equals(extension)) != default(FileMetadata);
        }

        private void InsertUploadedFileMetadataToDatabase(FileMetadata fileMetadata)
        {
            _unitOfWork.GetRepository<FileMetadata>().Add(fileMetadata);
            _unitOfWork.SaveChanges();
        }

        private bool DeleteUploadedFileMetadataFromDatabase(string discriminator, int? documentId, string fileName, string extension)
        {
            var fileMetadataToDelete = SelectFileMetadataFromDatabase(discriminator, documentId, fileName, extension);
            if(fileMetadataToDelete != default(FileMetadata))
            {
                _unitOfWork.GetRepository<FileMetadata>().Delete();
                return true;
            }

            return false;
        }

        private FileMetadata SelectFileMetadataFromDatabase(string discriminator, int? documentId, string fileName, string extension)
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

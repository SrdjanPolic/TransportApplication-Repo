using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.Settings;
using Service.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace TransportWebAPI.Controllers.Upload
{
    public class DirectoryCreator
    {
        private readonly AppDbContext _ctx;

        public DirectoryCreator(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public void CreateFolderForFileUpload()
        {
            CreateSettingsDatabaseEntryForFolderNameIfNotExists();
            var uploadFolderName = ReadFolderNameFromSettingsDatatable();
            var currentDirectory = Directory.GetCurrentDirectory();
            var pathToSave = Path.Combine(Directory.GetParent(currentDirectory).FullName, uploadFolderName);
            Directory.CreateDirectory(pathToSave);
            
        }



        private string ReadFolderNameFromSettingsDatatable()
        {
            string folderName = string.Empty;
            if (_ctx.SettingsTable.Any(x => x.ObjectName.Equals(Constants.FileUploadFolderName)))
            {
                folderName = _ctx.SettingsTable.Single(x => x.ObjectName.Equals(Constants.FileUploadFolderName)).Prefix;
            }

            return folderName;
        }

        private void CreateSettingsDatabaseEntryForFolderNameIfNotExists()
        {
            string uploadFolderName = "Documents";
            //First save Upload Folder Name in Settings table if not exist
            if (!_ctx.SettingsTable.Any(x => x.ObjectName.Equals(Constants.FileUploadFolderName)))
            {
                var settings = new Settings
                {
                    ObjectName = Constants.FileUploadFolderName,
                    Prefix = uploadFolderName
                };

                _ctx.SettingsTable.Add(settings);

                _ctx.SaveChanges();
            }
        }
    }
}

using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.Settings;
using System;
using System.IO;
using System.Linq;
using System.Security.AccessControl;


namespace TransportWebAPI.Controllers.Upload
{
    public class UploadDirectoryService
    {
        private readonly AppDbContext _ctx;
        private EmailSendingClient _emailSendingClient;


        public UploadDirectoryService(AppDbContext ctx, EmailSendingClient emailSendingClient)
        {
            _ctx = ctx;
            _emailSendingClient = emailSendingClient;           
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

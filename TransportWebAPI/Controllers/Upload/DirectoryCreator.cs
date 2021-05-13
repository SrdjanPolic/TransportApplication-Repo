using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.Settings;
using System.IO;
using System.Linq;
using System.Security.AccessControl;


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
            //var userId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            try
            {
                CreateSettingsDatabaseEntryForFolderNameIfNotExists();
                var uploadFolderName = ReadFolderNameFromSettingsDatatable();
                var currentDirectory = Directory.GetCurrentDirectory();
                var pathToSave = Path.Combine(Directory.GetParent(currentDirectory).FullName, uploadFolderName);
                Directory.CreateDirectory(pathToSave);
            }
            catch
            {
                
            }
            
            //AddDirectorySecurity(pathToSave, userId, FileSystemRights.Write, AccessControlType.Allow);
            //AddDirectorySecurity(pathToSave, userId, FileSystemRights.Read, AccessControlType.Allow);
            //AddDirectorySecurity(pathToSave, userId, FileSystemRights.Modify, AccessControlType.Allow);
            //AddDirectorySecurity(pathToSave, userId, FileSystemRights.ExecuteFile, AccessControlType.Deny);
        }

        private void AddDirectorySecurity(string FileName, string Account, FileSystemRights Rights, AccessControlType ControlType)
        {
            // Create a new DirectoryInfo object.
            DirectoryInfo dInfo = new DirectoryInfo(FileName);

            // Get a DirectorySecurity object that represents the
            // current security settings.
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            // Add the FileSystemAccessRule to the security settings.
            dSecurity.AddAccessRule(new FileSystemAccessRule(Account,
                                                            Rights,
                                                            ControlType));

            // Set the new access settings.
            dInfo.SetAccessControl(dSecurity);
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
            string uploadFolderName = "Trtmrt";
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

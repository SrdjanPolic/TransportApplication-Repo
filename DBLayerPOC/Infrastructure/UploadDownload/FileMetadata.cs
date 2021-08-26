using DBLayerPOC.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.UploadDownload
{
    public class FileMetadata : Entity
    {
        public string Discriminator { get; set; }
        public string Extension { get; set; }
        public string FileName { get; set; }
        public string GeneratedFileName { get; set; }
        public int? DocumentId { get; set; }
    }
}

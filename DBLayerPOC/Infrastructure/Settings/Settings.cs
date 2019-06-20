using DBLayerPOC.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.Settings
{
    public class Settings : Entity
    {
        public string ObjectName { get; set; }
        public string Prefix { get; set; }
        public int Year { get; set; }
        public int LastUsedNumber { get; set; }
    }
}

﻿using DBLayerPOC.Infrastructure.SalesInvoice;
using Repository.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.Driver
{
    public class Driver : Entity
    {
        public string Name { get; set; }
        public string PersonalIdNummber { get; set; }
        public DateTime PersonalIdExpDate { get; set; }
        public string PassNumber { get; set; }
        public DateTime PassExpDate { get; set; }
        public string DriversLicenceNumber { get; set; }
        public DateTime DriversLicenceExpDate { get; set; }
        public string Address { get; set; }
        public string Remark { get; set; }
        public bool IsInactive { get; set; }       
    }
}

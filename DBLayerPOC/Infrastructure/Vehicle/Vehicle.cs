using DBLayerPOC.Infrastructure.SalesInvoice;
using Repository.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.Vehicle
{
    public class Vehicle : Entity
    {
        public string RegistrationNumber { get; set; }
        public float MaxWeight { get; set; }
        public string ChassisNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string VechicleType { get; set; }
        public bool IsInactive { get; set; }
        public string Remark { get; set; }
    }
}

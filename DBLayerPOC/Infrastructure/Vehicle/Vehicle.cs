using DBLayerPOC.Infrastructure.SalesInvoice;
using DBLayerPOC.ModelBase;
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
        public string FuelType { get; set; }
        public string VechicleType { get; set; }
        public bool IsInactive { get; set; }

        public ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; }

        public Vehicle()
        {
            SalesInvoiceHeaders = new HashSet<SalesInvoiceHeader>();
        }
    }
}

using DBLayerPOC.Infrastructure.SalesInvoice;
using DBLayerPOC.ModelBase;
using System;
using System.Collections.Generic;

namespace DBLayerPOC.Models
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public int VatGroup { get; set; }
        public string VatNumber { get; set; }
        public bool IsInactive { get; set; }

        public string PersonalIdNumber { get; set; }
      
        public ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; }

        public Customer()
        {
            SalesInvoiceHeaders = new HashSet<SalesInvoiceHeader>();
        }
    }
}

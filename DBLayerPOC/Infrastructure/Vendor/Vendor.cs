﻿using DBLayerPOC.Infrastructure.PurchaseInvoice;
using DBLayerPOC.ModelBase;
using DBLayerPOC.Models;
using System;
using System.Collections.Generic;

namespace DBLayerPOC.Infrastructure.Vendor
{
    public class Vendor : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string PaymentTermsCode { get; set; }
        public int PaymentCurrency { get; set; }
        public string VatNumber { get; set; }
        public bool? IsInactive { get; set; }
        public DateTime LastChangeDate { get; set; }
        public string Note { get; set; }

        public ICollection<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; }

        public Vendor()
        {
            PurchaseInvoiceHeaders = new HashSet<PurchaseInvoiceHeader>();
        }
    }
}

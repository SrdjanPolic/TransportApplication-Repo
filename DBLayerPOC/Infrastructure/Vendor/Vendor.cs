﻿using DBLayerPOC.ModelBase;
using DBLayerPOC.Models;
using System;

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
        public int VatGroup { get; set; }
        public string VatNumber { get; set; }
        public bool IsInactive { get; set; }
        public DateTime LastChangeDate { get; set; }

        public int CurrencyExchangeRateId { get; set; }
        public CurrencyExchangeRate CurrencyExchangeRate { get; set; }
    }
}

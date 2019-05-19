using DBLayerPOC.Infrastructure.PurchaseInvoice;
using DBLayerPOC.Infrastructure.Vendor;
using DBLayerPOC.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Models
{
    public class Currency : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<Vendor> Vendors { get; }
        public ICollection<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; }
        public ICollection<CurrencyExchangeRate> CurrencyExchangeRates { get; }

        public Currency()
        {
            CurrencyExchangeRates = new HashSet<CurrencyExchangeRate>();
            Vendors = new HashSet<Vendor>();
            PurchaseInvoiceHeaders = new HashSet<PurchaseInvoiceHeader>();
        }
    }
}

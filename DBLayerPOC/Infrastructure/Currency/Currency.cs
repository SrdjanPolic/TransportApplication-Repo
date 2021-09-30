using DBLayerPOC.Infrastructure.PurchaseInvoice;
using DBLayerPOC.Infrastructure.SalesInvoice;
using DBLayerPOC.Infrastructure.Vendor;
using Repository.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Models
{
    public class Currency : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; }
        public ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; }
        public ICollection<CurrencyExchangeRate> CurrencyExchangeRates { get; }

        public Currency()
        {
            CurrencyExchangeRates = new HashSet<CurrencyExchangeRate>();
            PurchaseInvoiceHeaders = new HashSet<PurchaseInvoiceHeader>();
            SalesInvoiceHeaders = new HashSet<SalesInvoiceHeader>();
        }
    }
}

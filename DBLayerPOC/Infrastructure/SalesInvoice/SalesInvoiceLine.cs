using DBLayerPOC.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.SalesInvoice
{
    public class SalesInvoiceLine : Entity
    {
        public DateTime? LoadDate { get; set; }
        public DateTime? UnloadDate { get; set; }
        public string LoadAddress { get; set; }
        public string UnloadAddress { get; set; }
        public string ExportCustoms { get; set; }
        public string ImportCustoms { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float DiscountPercent { get; set; }
        public float LineAmount { get; set; }
        public string Remark { get; set; }
        public string Description { get; set; }
        public float VatPercent { get; set; }
        public int SalesHeaderId { get; set; }
        public SalesInvoiceHeader Header { get; set; }
    }
}

using DBLayerPOC.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Infrastructure.PurchaseInvoice
{
    public class PurchaseInvoiceLine : Entity
    {
        public string TravelOrder { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float DiscountPercent { get; set; }
        public float LineAmount { get; set; }
        public string Remark { get; set; }
        public string Description { get; set; }
        public float VatPercent { get; set; }
        public int PurchaseHeaderId { get; set; }
        public PurchaseInvoiceHeader Header { get; set; }
        public int? VehicleId { get; set; }
    }
}

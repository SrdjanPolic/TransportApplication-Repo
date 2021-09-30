

using Repository.ModelBase;

namespace DBLayerPOC.Infrastructure.SalesInvoice
{
    public class SalesInvoiceLine : Entity
    {
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

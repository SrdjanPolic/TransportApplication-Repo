using DBLayerPOC.ModelBase;
using DBLayerPOC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DBLayerPOC.Infrastructure.PurchaseInvoice
{
    public class PurchaseInvoiceHeader : Entity
    {
        public string SupplierInvoiceNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime PostingDate { get; set; }
        public string ExternalReferenceNo { get; set; }
        public DateTime DueDate { get; set; }
        public float TotalAmount { get; set; }
        public float TotalAmountLocal { get; set; }
        public bool Paid { get; set; }
        public bool Invoiced { get; set; }
        public bool CreditMemo { get; set; }
        public DateTime PaymentDate { get; set; }
        public ICollection<PurchaseInvoiceLine> Lines { get; }
        public string PurchaseSupplierNumber { get; set; }
        public bool PartiallyPayed { get; set; }
        [NotMapped]
        public string DeletedInvoiceLineIds { get; set; }

        [NotMapped]
        public string VendorName => Vendor != null ? Vendor.Name : string.Empty;

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public int VendorId { get; set; }
        public Vendor.Vendor Vendor { get; set; }

        public PurchaseInvoiceHeader()
        {
            Lines = new HashSet<PurchaseInvoiceLine>();
        }

    }
}

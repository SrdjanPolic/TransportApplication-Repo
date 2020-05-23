using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportWebAPI.Controllers.Reports
{
    public class SalesInvoicePaymentReportItem
    {
        public float TotalAmount { get; set; }
        public float TotalAmountLocal { get; set; }
        public bool Paid { get; set; }
        public double Delay { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime DueDate { get; set; }

    }
}

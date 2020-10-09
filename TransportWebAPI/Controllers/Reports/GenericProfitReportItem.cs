using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace TransportWebAPI.Controllers.Reports
{
    public class GenericProfitReportItem
    {
        public string TravelOrderNo { get; set; }
        public string Partner { get; set; }
        public float Input { get; set; }
        public float Output { get; set; }
        public string DocumentNo { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}

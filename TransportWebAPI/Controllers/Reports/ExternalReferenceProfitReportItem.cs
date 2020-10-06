using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportWebAPI.Controllers.Reports
{
    public class ExternalReferenceProfitReportItem
    {
        public string TravelOrderNo { get; set; }
        public string Sales { get; set; }
        public string Buyer { get; set; }
        public float Input { get; set; }
        public float Output { get; set; }
        public string DocumentNo { get; set; }
    }
}

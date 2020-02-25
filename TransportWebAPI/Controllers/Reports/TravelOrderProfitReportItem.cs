using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportWebAPI.Controllers.Reports
{
    public class TravelOrderProfitReportItem
    {
        public string TravelOrder { get; set; }
        public float Revenue { get; set; }
        public float Expences { get; set; }
        public float Profit { get; set; }
    }
}

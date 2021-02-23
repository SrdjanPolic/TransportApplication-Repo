using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportWebAPI.Controllers.Reports
{
    public class ProfitReportItem
    {
        public string Criteria { get; set; }
        public float Revenue { get; set; }
        public float Expences { get; set; }
        public float Profit { get; set; }
        public string SalesPerson { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportWebAPI.Controllers.Reports
{
    public class DatumQueryItem
    {
        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }
    }
}

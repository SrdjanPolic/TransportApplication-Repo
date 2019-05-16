using DBLayerPOC.Infrastructure.Vendor;
using DBLayerPOC.ModelBase;
using System;
using System.Collections.Generic;

namespace DBLayerPOC.Models
{
    public class CurrencyExchangeRate : Entity
    {
        public float ExchangeRateAmount { get; set; }
        public DateTime StartingDate { get; set; }
        private readonly ICollection<Vendor> _vendors;
        public ICollection<Vendor> Vendors { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public CurrencyExchangeRate()
        {
            _vendors = new HashSet<Vendor>();
        }
        
    }
}

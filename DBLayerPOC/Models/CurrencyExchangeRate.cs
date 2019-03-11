using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Models
{
    public class CurrencyExchangeRate : Entity
    {
        public float ExchangeRateAmount { get; set; }
        public DateTime StartingDate { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}


using Repository.ModelBase;
using System;
using System.Collections.Generic;

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

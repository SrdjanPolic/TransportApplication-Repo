using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Models
{
    public class Currency : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        private ICollection<CurrencyExchangeRate> _currencyExchangeRates;
        public ICollection<CurrencyExchangeRate> CurrencyExchangeRates => _currencyExchangeRates;

        public Currency()
        {
            _currencyExchangeRates = new HashSet<CurrencyExchangeRate>();
        }
    }
}

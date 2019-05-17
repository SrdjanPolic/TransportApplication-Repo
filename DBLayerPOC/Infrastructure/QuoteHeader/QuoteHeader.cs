using DBLayerPOC.ModelBase;
using System.Collections.Generic;


namespace DBLayerPOC.Models
{
    public class QuoteHeader : Entity
    {
        public string Header { get; set; }
        public ICollection<QuoteLine> QuoteLines { get; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string CurrencyCode { get; set; }
        public float CurrencyExchangeRate { get; set; }

        public QuoteHeader()
        {
            QuoteLines = new HashSet<QuoteLine>();
        }
    }
}

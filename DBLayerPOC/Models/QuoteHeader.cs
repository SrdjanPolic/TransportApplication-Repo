using System.Collections.Generic;


namespace DBLayerPOC.Models
{
    public class QuoteHeader : Entity
    {
        public string Header { get; set; }
        private readonly ICollection<QuoteLine> _quoteLines;
        public ICollection<QuoteLine> QuoteLines => _quoteLines;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public QuoteHeader()
        {
            _quoteLines = new HashSet<QuoteLine>();
        }
    }
}

using DBLayerPOC.ModelBase;

namespace DBLayerPOC.Models
{
    public class QuoteLine : Entity
    {
        public string From { get; set; }
        public string To { get; set; }
        public int QuoteHeaderId { get; set; }
        public QuoteHeader QuoteHeader { get; set; }
    }
}

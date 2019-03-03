using System;
using System.Collections.Generic;
using System.Text;

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

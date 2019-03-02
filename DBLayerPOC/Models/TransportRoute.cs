using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Models
{
    public class TransportRoute : Entity
    {
        public string From { get; set; }
        public string To { get; set; }
        public int TransportOfferId { get; set; }
        public TransportOffer TransportOffer { get; set; }
    }
}

using System.Collections.Generic;


namespace DBLayerPOC.Models
{
    public class TransportOffer : Entity
    {
        public string Header { get; set; }
        private readonly ICollection<TransportRoute> _transportRoutes;
        public ICollection<TransportRoute> TransportRoutes => _transportRoutes;

        public TransportOffer()
        {
            _transportRoutes = new HashSet<TransportRoute>();
        }
    }
}

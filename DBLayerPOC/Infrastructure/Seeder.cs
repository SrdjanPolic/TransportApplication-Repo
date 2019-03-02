using DBLayerPOC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DBLayerPOC.Infrastructure
{
    public class Seeder
    {
        private readonly TransportDbContext _ctx;

        public Seeder(TransportDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if(!_ctx.TransportOffers.Any())
            {
                for (int i = 0; i < 10000; i++)
                {
                    var offer = new TransportOffer()
                    {
                        Header = Path.GetRandomFileName(),
                    };

                    for (int j = 0; j < 3; j++)
                    {
                        var route = new TransportRoute
                        {
                            From = Path.GetRandomFileName(),
                            To = Path.GetRandomFileName(),
                            TransportOffer = offer
                        };

                        offer.TransportRoutes.Add(route);
                        _ctx.TransportRoutes.Add(route);
                    }

                    _ctx.TransportOffers.Add(offer);                  
                    
                }

                _ctx.SaveChanges();
            }
        }
    }
}

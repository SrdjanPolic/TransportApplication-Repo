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
        private readonly QuoteHeaderDbContext _ctx;

        public Seeder(QuoteHeaderDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Seed()
        {
            //_ctx.Database.EnsureCreated();

            //if (!_ctx.Customers.Any())
            //{
            //    var customer1 = new Customer
            //    {
            //        Name = "Mika Mikic",
            //        Address = "Gustava Krkleca 1c",
            //        City = "Vrbas",
            //        Country = "Srbija",
            //        PhoneNo = "021345445",
            //        Email = "abc@yahoo.com",
            //        PaymentTermsCode = "5 weeks",
            //        VatGroup = 3,
            //        IsActive = true
            //    };

            //    _ctx.Customers.Add(customer1);

            //    var customer2 = new Customer
            //    {
            //        Name = "Pera Peric",
            //        Address = "Akacija 29",
            //        City = "Sabac",
            //        Country = "Srbija",
            //        PhoneNo = "02234562",
            //        Email = "iuyt@yahoo.com",
            //        PaymentTermsCode = "8 weeks",
            //        VatGroup = 4,
            //        IsActive = true
            //    };

            //    _ctx.Customers.Add(customer2);

            //    _ctx.SaveChanges();

            //}

            //if (!_ctx.TransportOffers.Any())
            //{
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        var header = new QuoteHeader()
            //        {
            //            Header = Path.GetRandomFileName(),
            //            CustomerId = i % 2 + 1
            //        };

            //        for (int j = 0; j < 3; j++)
            //        {
            //            var route = new QuoteLine
            //            {
            //                From = Path.GetRandomFileName(),
            //                To = Path.GetRandomFileName(),
            //                QuoteHeader = header
            //            };

            //            header.QuoteLines.Add(route);
            //            _ctx.TransportRoutes.Add(route);
            //        }

            //        _ctx.TransportOffers.Add(header);

            //    }

            //    _ctx.SaveChanges();
            //}
        }
    }
}

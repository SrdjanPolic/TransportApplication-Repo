using DBLayerPOC.Infrastructure.PurchaseInvoice;
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
        private readonly AppDbContext _ctx;

        public Seeder(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();


            if(!_ctx.SettingsTable.Any())
            { 
                var PurchaseInvoiceNumber = _ctx.PurchaseInvoiceHeaders.Count();
                var settings = new Settings.Settings
                {
                    ObjectName = "PurchaseInvoice",
                    Prefix = "UF-19",
                    Year = 2019,
                    LastUsedNumber = PurchaseInvoiceNumber
                };

                _ctx.SettingsTable.Add(settings);
            }

            //for (int i = 0; i < 20; i++)
            //{
            //    var invoiceHeader = new PurchaseInvoiceHeader
            //    {
            //        InvoiceNo = "Faktura Broj" + i,
            //        PostingDate = DateTime.Now.AddDays(-i - 1),
            //        ExternalReferenceNo = "abc " + i,
            //        DueDate = DateTime.Now.AddDays(i + 1),
            //        Paid = false,
            //        Invoiced = false,
            //        CreditMemo = false,
            //        PaymentDate = DateTime.Now.AddDays(i + 10),
            //        CurrencyId = 1,
            //        VendorId = 10,
            //        TotalAmount = 0F
            //    };

            //    for (int j = 0; j < 3; j++)
            //    {
            //        var invoiceLine = new PurchaseInvoiceLine
            //        {
            //            Header = invoiceHeader,
            //            Quantity = 1,
            //            UnitPrice = 250,
            //            DiscountPercent = 0,
            //            LineAmount = 0,
            //            Remark = "bla",
            //            Description = "bla bla",
            //            VatPercent = 18
            //        };

            //        _ctx.PurchaseInvoiceLines.Add(invoiceLine);
            //    }

            //    _ctx.PurchaseInvoiceHeaders.Add(invoiceHeader);
            //}

            _ctx.SaveChanges();


            //for (int i = 0; i < 30; i++)
            //{
            //    var exRate = new CurrencyExchangeRate
            //    {
            //        ExchangeRateAmount = 117.87F + 0.1F * i,
            //        StartingDate = DateTime.Now.AddDays(-i),
            //        CurrencyId = 12
            //    };

            //    _ctx.CurrencyExchangeRates.Add(exRate);
            //}

            //_ctx.SaveChanges();

            //for (int i = 0; i < 30; i++)
            //{
            //    var vendor = new Vendor.Vendor
            //    {
            //        Name = "Vendor " + i,
            //        Address = "Adresa " + i,
            //        City = "Grad" + i,
            //        Country = "Zemlja" + i,
            //        PhoneNo = "Telefon" + i,
            //        Email = "Email" + i,
            //        PaymentTermsCode = "Valuta" + i,
            //        VatGroup = 20,
            //        VatNumber = "PDV Broj" + i,
            //        LastChangeDate = DateTime.Now.AddDays(-i),
            //        IsInactive = false,
            //        //CurrencyId = 12,
            //    };

            //    _ctx.Vendors.Add(vendor);
            //}

            //for (int i = 0; i < 5000; i++)
            //{
            //    var customer = new Customer
            //    {
            //        Name = "Korisnik " + i,
            //        Address = "Adresa korisnika " + i,
            //        City = "City " + i,
            //        Country = "Country " + i,
            //        PhoneNo = "Telefon " + i,
            //        Email = "Email " + i,
            //        VatGroup = 3,
            //        IsInactive = false

            //    };

            //    _ctx.Customers.Add(customer);
            //}


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

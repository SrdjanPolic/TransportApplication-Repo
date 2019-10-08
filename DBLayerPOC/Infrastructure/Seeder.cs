using DBLayerPOC.Infrastructure.Login;
using DBLayerPOC.Infrastructure.PurchaseInvoice;
using DBLayerPOC.Infrastructure.SalesInvoice;
using DBLayerPOC.Infrastructure.Settings;
using DBLayerPOC.Models;
using Microsoft.EntityFrameworkCore;
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

            if(!_ctx.Currencies.Any())
            {
                var currencuDinar = new Currency
                {
                    Code = "RSD",
                    Name = "Dinar"
                };

                _ctx.Currencies.Add(currencuDinar);

                var currencyEuro = new Currency
                {
                    Code = "EUR",
                    Name = "Euro"
                };

                _ctx.Currencies.Add(currencyEuro);

                _ctx.SaveChanges();

            }

            if (!_ctx.CurrencyExchangeRates.Any())
            {
                //for (int i = 0; i < 30; i++)
                {
                    var exRate = new CurrencyExchangeRate
                    {
                        ExchangeRateAmount = 117.5F,
                        StartingDate = DateTime.UtcNow,
                        CurrencyId = 1
                    };

                    _ctx.CurrencyExchangeRates.Add(exRate);
                }

                _ctx.SaveChanges();
            }

            //if (!_ctx.Vendors.Any())
            //{
            //    for (int i = 0; i < 30; i++)
            //    {
            //        var vendor = new Vendor.Vendor
            //        {
            //            Name = "Vendor " + i,
            //            Address = "Adresa " + i,
            //            City = "Grad" + i,
            //            Country = "Zemlja" + i,
            //            PhoneNo = "Telefon" + i,
            //            Email = "Email" + i,
            //            PaymentTermsCode = "Valuta" + i,
            //            VatGroup = 20,
            //            VatNumber = "PDV Broj" + i,
            //            LastChangeDate = DateTime.Now.AddDays(-i),
            //            IsInactive = false
            //        };

            //        _ctx.Vendors.Add(vendor);

            //    }

            //    _ctx.SaveChanges();
            //}


            //if (!_ctx.Customers.Any())
            //{
            //    for (int i = 0; i < 5000; i++)
            //    {
            //        var customer = new Customer
            //        {
            //            Name = "Korisnik " + i,
            //            Address = "Adresa korisnika " + i,
            //            City = "City " + i,
            //            Country = "Country " + i,
            //            PhoneNo = "Telefon " + i,
            //            Email = "Email " + i,
            //            VatGroup = 3,
            //            IsInactive = false
            //        };

            //        _ctx.Customers.Add(customer);
            //    }

            //    _ctx.SaveChanges();
            //}

            if (!_ctx.SettingsTable.Any(x => x.ObjectName.Equals(Constants.PurchaseInvoiceObjectName)))
            {
                var PurchaseInvoiceNumber = _ctx.PurchaseInvoiceHeaders.Count();
                var settings = new Settings.Settings
                {
                    ObjectName = Constants.PurchaseInvoiceObjectName,
                    Prefix = "UF-19",
                    Year = 2019,
                    LastUsedNumber = PurchaseInvoiceNumber
                };

                _ctx.SettingsTable.Add(settings);
            }

            if (!_ctx.SettingsTable.Any(x => x.ObjectName.Equals(Constants.SalesInvoiceObjectName)))
            {
                var SalesInvoiceNumber = _ctx.SalesInvoiceHeaders.Count();
                var settings = new Settings.Settings
                {
                    ObjectName = Constants.SalesInvoiceObjectName,
                    Prefix = "IF-19",
                    Year = 2019,
                    LastUsedNumber = SalesInvoiceNumber
                };

                _ctx.SettingsTable.Add(settings);
            }

            _ctx.SaveChanges();

            //if (!_ctx.Drivers.Any())
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        var driver = new Driver.Driver
            //        {
            //            Name = "Vozac" + i,
            //            PersonalIdNummber = Path.GetRandomFileName(),
            //            PersonalIdExpDate = DateTime.Now,
            //            PassNumber = Path.GetRandomFileName(),
            //            PassExpDate = DateTime.Now,
            //            DriversLicenceNumber = Path.GetRandomFileName(),
            //            DriversLicenceExpDate = DateTime.Now,
            //            Address = Path.GetRandomFileName(),
            //            Remark = Path.GetRandomFileName(),
            //            IsInactive = false
            //        };

            //        _ctx.Drivers.Add(driver);
            //    }

            //    _ctx.SaveChanges();
            //}

            //if (!_ctx.Vehicles.Any())
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        var vehicle = new Vehicle.Vehicle
            //        {
            //            RegistrationNumber = Path.GetRandomFileName(),
            //            MaxWeight = 2000,
            //            ChassisNumber = Path.GetRandomFileName(),
            //            FuelType = "Diesel",
            //            VechicleType = "KOmbi",
            //            IsInactive = false,
            //            Remark = Path.GetRandomFileName()
            //        };

            //        _ctx.Vehicles.Add(vehicle);
            //    }

            //    _ctx.SaveChanges();
            //}

            //if (!_ctx.SalesInvoiceHeaders.Any())
            //{

            //    for (int i = 0; i < 20; i++)
            //    {
            //        var invoiceHeader = new SalesInvoiceHeader
            //        {
            //            InvoiceNo = "Faktura Broj" + i,
            //            PostingDate = DateTime.Now.AddDays(-i - 1),
            //            ExternalReferenceNo = "abc " + i,
            //            DueDate = DateTime.Now.AddDays(i + 1),
            //            SalesPerson = "Sales Person " + i,
            //            OrderDate = DateTime.Now,
            //            Paid = false,
            //            Invoiced = false,
            //            CreditMemo = false,
            //            PaymentDate = DateTime.Now.AddDays(i + 10),
            //            CurrencyId = 1,
            //            CustomerId = 6,
            //            TotalAmount = 18F,
            //            TotalAmountLocal = 12.45F,
            //            CommodityType = "bla",
            //            NumberOfPallets = 12,
            //            NumberOfPalletsPlaces = 12,
            //            BruttoWeight = 90F,
            //            AdrNeeded = true,
            //            Remarks = "blabla",
            //            VehicleId = 2,
            //            DriverId = 1,
            //            RouteDistance = 1200,
            //            LoadRepresentative = "Vucic",
            //            PricePerKm = 12,
            //            CrmNumber = "lincl"
            //        };

            //        for (int j = 0; j < 3; j++)
            //        {
            //            var invoiceLine = new SalesInvoiceLine
            //            {
            //                Header = invoiceHeader,
            //                LoadDate = DateTime.Now,
            //                UnloadDate = DateTime.Now,
            //                LoadAddress = "Adr1",
            //                UnloadAddress = "Adr2",
            //                ExportCustoms = "Cust1",
            //                ImportCustoms = "Cust2",
            //                Quantity = 23,
            //                UnitPrice = 250,
            //                DiscountPercent = 0,
            //                LineAmount = 0,
            //                Remark = "bla",
            //                Description = "bla bla",
            //                VatPercent = 18
            //            };

            //            _ctx.SalesInvoiceLines.Add(invoiceLine);
            //        }

            //        _ctx.SalesInvoiceHeaders.Add(invoiceHeader);

            //    }

            //    _ctx.SaveChanges();
            //}
            //else
            //{
            //    foreach(SalesInvoiceHeader header in _ctx.SalesInvoiceHeaders)
            //    {
            //        header.DriverId = 2;
            //        header.VehicleId = 5;

            //        _ctx.Entry(header).State = EntityState.Modified;
            //    }

            //    _ctx.SaveChanges();
            //}

            //if (!_ctx.PurchaseInvoiceHeaders.Any())
            //{
            //    for (int i = 0; i < 20; i++)
            //    {
            //        var invoiceHeader = new PurchaseInvoiceHeader
            //        {
            //            InvoiceNo = "Faktura Broj" + i,
            //            PostingDate = DateTime.Now.AddDays(-i - 1),
            //            ExternalReferenceNo = "abc " + i,
            //            DueDate = DateTime.Now.AddDays(i + 1),
            //            Paid = false,
            //            Invoiced = false,
            //            CreditMemo = false,
            //            PaymentDate = DateTime.Now.AddDays(i + 10),
            //            CurrencyId = 1,
            //            VendorId = 8,
            //            TotalAmount = 0F
            //        };

            //        for (int j = 0; j < 3; j++)
            //        {
            //            var invoiceLine = new PurchaseInvoiceLine
            //            {
            //                Header = invoiceHeader,
            //                Quantity = 1,
            //                UnitPrice = 250,
            //                DiscountPercent = 0,
            //                LineAmount = 0,
            //                Remark = "bla",
            //                VehicleId = 1,
            //                Description = "bla bla",
            //                VatPercent = 18
            //            };

            //            _ctx.PurchaseInvoiceLines.Add(invoiceLine);
            //        }

            //        _ctx.PurchaseInvoiceHeaders.Add(invoiceHeader);
            //    }

            //    _ctx.SaveChanges();
            //}
            //else
            //{
            //    foreach(PurchaseInvoiceLine line in _ctx.PurchaseInvoiceLines)
            //    {
            //        line.VehicleId = 5;
            //        _ctx.Entry(line).State = EntityState.Modified;
            //    }

            //    _ctx.SaveChanges();
            //}


            //if (!_ctx.SettingsTable.Any(x => x.ObjectName.Equals(Constants.SalesInvoiceObjectName)))
            //{
            //    var SalesInvoiceNumber = _ctx.SalesInvoiceHeaders.Count();
            //    var settings = new Settings.Settings
            //    {
            //        ObjectName = Constants.SalesInvoiceObjectName,
            //        Prefix = "IF-19",
            //        Year = 2019,
            //        LastUsedNumber = SalesInvoiceNumber
            //    };

            //    _ctx.SettingsTable.Add(settings);
            //}


            //_ctx.SaveChanges();

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

            if (!_ctx.Login.Any())
            {
                var login = new LoginModel
                {
                    Name = "admin",
                    Username = "admin",
                    Password = "admin",
                    IsAdmin = true,
                    IsInactive = false
                };

                _ctx.Login.Add(login);

                var login1 = new LoginModel
                {
                    Username = "user",
                    Password = "user",
                    Name = "user",
                    IsAdmin = false,
                    IsInactive = false  
                };

                _ctx.Login.Add(login1);

            }

            _ctx.SaveChanges();
        }
    }
}

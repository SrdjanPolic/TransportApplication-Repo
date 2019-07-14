﻿using DBLayerPOC.ModelBase;
using DBLayerPOC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DBLayerPOC.Infrastructure.SalesInvoice
{
    public class SalesInvoiceHeader : Entity
    {
        public string InvoiceNo { get; set; }
        public DateTime PostingDate { get; set; }
        public string ExternalReferenceNo { get; set; }
        public DateTime DueDate { get; set; }
        public string SalesPerson { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        public float TotalAmountLocal { get; set; }
        public bool Paid { get; set; }
        public bool Invoiced { get; set; }
        public bool CreditMemo { get; set; }
        public DateTime PaymentDate { get; set; }
        public ICollection<SalesInvoiceLine> Lines { get; }
        public bool PartiallyPayed { get; set; }

        public string CommodityType { get; set; }
        public double NumberOfPallets { get; set; }
        public double NumberOfPalletsPlaces { get; set; }
        public float BruttoWeight { get; set; }
        public bool AdrNeeded { get; set; }
        public string Remarks { get; set; }
        public float RouteDistance { get; set; }
        public string LoadRepresentative { get; set; }
        public float PricePerKm { get; set; }
        public string CrmNumber { get; set; }


        [NotMapped]
        public string DeletedInvoiceLineIds { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int DriverId { get; set; }
        public Driver.Driver Driver { get; set; }

        public int VehicleId { get; set; }
        public Vehicle.Vehicle Vehicle { get; set; }

        public SalesInvoiceHeader()
        {
            Lines = new HashSet<SalesInvoiceLine>();
        }
    }
}

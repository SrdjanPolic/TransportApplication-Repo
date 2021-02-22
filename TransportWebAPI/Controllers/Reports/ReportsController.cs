using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.PurchaseInvoice;
using DBLayerPOC.Infrastructure.SalesInvoice;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace TransportWebAPI.Controllers.Reports
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : Controller
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public ReportsController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET
        [Route("[action]/{paid}")]
        [HttpGet]
        public IActionResult GetSalesInvoicePaymentReport(bool paid)
        {
            var reportItems = new List<SalesInvoicePaymentReportItem>();
            if(paid)
            {
                var salesInvoicesPaid = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(header => header.Paid)
                    .Items.ToList();

                salesInvoicesPaid.ForEach(
                    x =>
                    {
                        var reportItem = new SalesInvoicePaymentReportItem
                        {
                            TotalAmount = x.TotalAmount,
                            TotalAmountLocal = x.TotalAmountLocal,
                            Paid = x.Paid,
                            PaymentDate = x.PaymentDate,
                            DueDate = x.DueDate,
                            Delay = Math.Round((x.PaymentDate - x.DueDate).TotalDays)
                        };

                        reportItems.Add(reportItem);
                    });
            }
            else
            {
                var salesInvoicesNotPaid = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(header => !header.Paid)
                    .Items.ToList();

                salesInvoicesNotPaid.ForEach(
                    x =>
                    {
                        var reportItem = new SalesInvoicePaymentReportItem
                        {
                            TotalAmount = x.TotalAmount,
                            TotalAmountLocal = x.TotalAmountLocal,
                            Paid = x.Paid,
                            PaymentDate = x.PaymentDate,
                            DueDate = x.DueDate,
                            Delay = Math.Round((DateTime.Now - x.DueDate).TotalDays)
                        };

                        reportItems.Add(reportItem);
                    });

            }
            return Ok(reportItems);
        }

        // GET
        [Route("[action]")]
        [HttpGet]
        public IActionResult GetTravelOrderProfitReport()
        {
            var reportItems = new List<ProfitReportItem>();

            var travelOrders = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(header => !header.CreditMemo && !string.IsNullOrEmpty(header.TravelOrder))
                    .Items.Select(x => x.TravelOrder).Distinct().ToList();

            travelOrders.ForEach(travelOrder =>
            {
                var reportProfitItem = GetTravelOrderProfitReportItem(travelOrder);
                reportItems.Add(reportProfitItem);
            });


            return Ok(reportItems);
        }

        // GET
        [Route("[action]")]
        [HttpPost]
        public IActionResult GetExternalReferenceProfitReport([FromBody] DatumQueryItem datumQueryItem) //staviti sopstveni = false;
        {
            var reportItems = new List<ProfitReportItem>();

            var externalReferences = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(header => !header.CreditMemo && !string.IsNullOrEmpty(header.ExternalReferenceNo) 
                     && !header.OwnTransport)
                    .Items.Select(x => x.ExternalReferenceNo).Distinct().ToList();

            externalReferences.ForEach(externalReference =>
            {
                var reportProfitItem = GetExternalReferenceProfitReportItem(externalReference, datumQueryItem);
                if (reportProfitItem != null)
                {
                    reportItems.Add(reportProfitItem);
                }
            });

            return Ok(reportItems);
        }

        // GET
        [Route("[action]/{*travelOrderNo}")]
        [HttpGet]
        public IActionResult GetTravelOrderProfitReportItems(string travelOrderNo)
        {
            var travelOrderProfilReportItems = new List<GenericProfitReportItem>();

            var salesList = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(predicate: header => header.TravelOrder.Equals(travelOrderNo) && !header.CreditMemo, orderBy:null, 
                     include: header => header.Include(x => x.Customer))
                    .Items.ToList();

            salesList.ForEach(sale =>
            {
                var externalReportProfitItem = new GenericProfitReportItem
                {
                    Partner = sale.Customer.Name,
                    SalesPerson = sale.SalesPerson,
                    Input = sale.TotalAmountLocal,
                    TravelOrderNo = sale.TravelOrder,
                    DocumentNo = sale.InvoiceNo, 
                    InvoiceDate = sale.PostingDate
                };

                travelOrderProfilReportItems.Add(externalReportProfitItem);
            });

            var purchaseList = _unitOfWork.GetRepository<PurchaseInvoiceLine>()
                .GetList(predicate: line => line.TravelOrder.Equals(travelOrderNo) && !line.Header.CreditMemo, orderBy: null,
                 include: line => line.Include(x => x.Header.Vendor))
                .Items.ToList();


            purchaseList.ForEach(purchase =>
            {
                var exchangeRate = GetExchangeRateForPurchase(purchase);
                var externalReportProfitItem = new GenericProfitReportItem
            
                {
                    Partner = purchase.Header.Vendor.Name,
                    Output = purchase.LineAmount * exchangeRate,
                    TravelOrderNo = purchase.TravelOrder,
                    DocumentNo = purchase.Header.InvoiceNo,
                    InvoiceDate = purchase.Header.PostingDate
                };

                travelOrderProfilReportItems.Add(externalReportProfitItem);
            });



            return Ok(travelOrderProfilReportItems);
        }

        // GET
        [Route("[action]/{*externalReference}")]
        [HttpGet]
        public IActionResult GetExternalReferenceReportItems(string externalReference)
        {
            var externalReferenceProfilReportItems = new List<GenericProfitReportItem>();

            var salesLinesList = _unitOfWork.GetRepository<SalesInvoiceLine>()
                    .GetList(predicate: line => line.Header.ExternalReferenceNo.Equals(externalReference) && !line.Header.CreditMemo, orderBy: null,
                     include: line => line.Include(x => x.Header.Customer))
                    .Items.ToList();

            salesLinesList.ForEach(line =>
            {
                var exchangeRate = line.Header.CurrencyId == 2 ? line.Header.CalculatonExchangeRate : 1;
                var externalReportProfitItem = new GenericProfitReportItem
                {
                    Partner = line.Header.Customer.Name,
                    SalesPerson = line.Header.SalesPerson,
                    Input = (float)Math.Round(line.LineAmount * exchangeRate / (1 + line.VatPercent / 100), 2, MidpointRounding.ToEven),
                    TravelOrderNo = line.Header.ExternalReferenceNo,
                    DocumentNo = line.Header.InvoiceNo,
                    InvoiceDate = line.Header.PostingDate
                };

                externalReferenceProfilReportItems.Add(externalReportProfitItem);
            });

            var purchaseList = _unitOfWork.GetRepository<PurchaseInvoiceLine>()
                .GetList(predicate: line => line.Header.ExternalReferenceNo.Equals(externalReference) && !line.Header.CreditMemo, orderBy: null,
                 include: line => line.Include(x => x.Header.Vendor))
                .Items.ToList();


            purchaseList.ForEach(purchase =>
            {
                var exchangeRate = GetExchangeRateForPurchase(purchase);

                var externalReportProfitItem = new GenericProfitReportItem
                {
                    Partner = purchase.Header.Vendor.Name,
                    Output = (float)Math.Round(purchase.LineAmount * exchangeRate/(1 + purchase.VatPercent/100), 2, MidpointRounding.ToEven),
                    TravelOrderNo = purchase.Header.ExternalReferenceNo,
                    DocumentNo = purchase.Header.InvoiceNo,
                    InvoiceDate = purchase.Header.PostingDate
                };

                externalReferenceProfilReportItems.Add(externalReportProfitItem);
            });



            return Ok(externalReferenceProfilReportItems);
        }

        private ProfitReportItem GetExternalReferenceProfitReportItem(string externalReference, DatumQueryItem datumQueryItem)
        {
            SalesInvoiceHeader oldestHeader;
            IList<SalesInvoiceHeader> salesList = new List<SalesInvoiceHeader>(); 
            if (datumQueryItem.FromDate == null && datumQueryItem.ToDate == null)
            {
                salesList = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(predicate: header => header.ExternalReferenceNo.Equals(externalReference) && !header.CreditMemo, orderBy: null,
                    include: header => header.Include(x => x.Lines))
                    .Items.ToList();
            }
            else if (datumQueryItem.FromDate != null && datumQueryItem.ToDate == null)
            {
                salesList = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(predicate: header => header.ExternalReferenceNo.Equals(externalReference) && !header.CreditMemo
                            && header.PostingDate.CompareTo(datumQueryItem.FromDate.Value) >= 0, orderBy: null,
                            include: header => header.Include(x => x.Lines))
                    .Items.ToList();
            }
            else if (datumQueryItem.FromDate == null && datumQueryItem.ToDate != null)
            {
                salesList = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(predicate: header => header.ExternalReferenceNo.Equals(externalReference) && !header.CreditMemo
                            && header.PostingDate.CompareTo(datumQueryItem.ToDate.Value) <= 0, orderBy: null,
                            include: header => header.Include(x => x.Lines))
                    .Items.ToList();
            }
            else if (datumQueryItem.FromDate != null && datumQueryItem.ToDate != null)
            {
                salesList = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(predicate: header => header.ExternalReferenceNo.Equals(externalReference) && !header.CreditMemo
                            && (header.PostingDate.CompareTo(datumQueryItem.FromDate.Value) >= 0)
                            && (header.PostingDate.CompareTo(datumQueryItem.ToDate.Value) <= 0), orderBy:null,
                            include: header => header.Include(x => x.Lines))
                    .Items.ToList();
            }

            if (!salesList.Any())
                return null;


            var revenue = salesList.Sum(x => x.Lines.Sum(y => y.LineAmount/(1 + y.VatPercent/100)));
           

            var purchaseList = _unitOfWork.GetRepository<PurchaseInvoiceLine>()
                .GetList(line => line.Header.ExternalReferenceNo.Equals(externalReference) && !line.Header.CreditMemo)
                .Items.ToList();


            var expences = purchaseList.Sum(purchase =>
            {
                var exchangeRate = GetExchangeRateForPurchase(purchase);
                var purchaseLineAmountLocal = purchase.LineAmount * exchangeRate;
                return purchaseLineAmountLocal/(1 + purchase.VatPercent / 100);
            });

            var profit = (float)Math.Round(revenue - expences, 2, MidpointRounding.ToEven);

            var reportItem = new ProfitReportItem
            {
                Criteria = externalReference,
                Revenue = revenue,
                Expences = expences,
                Profit = profit
            };

            return reportItem;
        }

        private ProfitReportItem GetTravelOrderProfitReportItem(string travelOrder)
        {
            var salesList = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(header => header.TravelOrder.Equals(travelOrder) && !header.CreditMemo)
                    .Items.ToList();

            var revenue = salesList.Sum(sale => sale.TotalAmountLocal);

            var purchaseList = _unitOfWork.GetRepository<PurchaseInvoiceLine>()
                .GetList(line => line.TravelOrder.Equals(travelOrder) && !line.Header.CreditMemo)
                .Items.ToList();


            var expences = purchaseList.Sum(purchase =>
            {
                var exchangeRate = GetExchangeRateForPurchase(purchase);
                return purchase.LineAmount * exchangeRate;
            });

            var profit = revenue - expences;

            var reportItem = new ProfitReportItem
            {
                Criteria = travelOrder,
                Revenue = revenue,
                Expences = expences,
                Profit = profit
            };

            return reportItem;
        }

        private float GetExchangeRateForPurchase(PurchaseInvoiceLine purchaseInvoiceLine)
        {
            var header = _unitOfWork.GetRepository<PurchaseInvoiceHeader>().Single(x => x.Id == purchaseInvoiceLine.PurchaseHeaderId);

            if (header.TotalAmount != 0)
            {
                return header.TotalAmountLocal / header.TotalAmount;
            }

            return 0;
        }
    }
}

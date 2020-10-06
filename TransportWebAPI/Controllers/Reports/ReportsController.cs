using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.PurchaseInvoice;
using DBLayerPOC.Infrastructure.SalesInvoice;
using Microsoft.AspNetCore.Mvc;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        [HttpGet]
        public IActionResult GetExternalReferenceProfitReport() //staviti sopstveni = false;
        {
            var reportItems = new List<ProfitReportItem>();

            var externalReferences = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(header => !header.CreditMemo && !string.IsNullOrEmpty(header.ExternalReferenceNo) 
                     && !header.OwnTransport)
                    .Items.Select(x => x.ExternalReferenceNo).Distinct().ToList();

            externalReferences.ForEach(externalReference =>
            {
                var reportProfitItem = GetExternalReferenceProfitReportItem(externalReference);
                reportItems.Add(reportProfitItem);
            });

            return Ok(reportItems);
        }

        // GET
        [Route("[action]/{travelOrderNo}")]
        [HttpGet]
        public IActionResult GetExternalReferenceProfitReportItems(string travelOrderNo)
        {
            var externalReferenceProfilReportItems = new List<ExternalReferenceProfitReportItem>();

            var salesList = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(header => header.ExternalReferenceNo.Equals(travelOrderNo) && !header.CreditMemo)
                    .Items.ToList();

            salesList.ForEach(sale =>
            {
                var externalReportProfitItem = new ExternalReferenceProfitReportItem
                {
                    Sales = sale.SalesPerson,
                    Input = sale.TotalAmountLocal,
                    TravelOrderNo = sale.ExternalReferenceNo,
                    DocumentNo = sale.InvoiceNo
                };

                externalReferenceProfilReportItems.Add(externalReportProfitItem);
            });

            var purchaseList = _unitOfWork.GetRepository<PurchaseInvoiceLine>()
                .GetList(line => line.Header.ExternalReferenceNo.Equals(travelOrderNo) && !line.Header.CreditMemo)
                .Items.ToList();


            purchaseList.ForEach(purchase =>
            {
                var exchangeRate = GetExchangeRateForPurchase(purchase);
            
                var externalReportProfitItem = new ExternalReferenceProfitReportItem
                {
                    Buyer = purchase.Header.Vendor.Name,
                    Output = purchase.LineAmount * exchangeRate,
                    TravelOrderNo = purchase.Header.ExternalReferenceNo,
                    DocumentNo = purchase.Header.InvoiceNo
                };

                externalReferenceProfilReportItems.Add(externalReportProfitItem);
            });



            return Ok(externalReferenceProfilReportItems);
        }

        private ProfitReportItem GetExternalReferenceProfitReportItem(string externalReference)
        {
            var salesList = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(header => header.ExternalReferenceNo.Equals(externalReference) && !header.CreditMemo)
                    .Items.ToList();

            var revenue = salesList.Sum(sale => sale.TotalAmountLocal);

            var purchaseList = _unitOfWork.GetRepository<PurchaseInvoiceLine>()
                .GetList(line => line.Header.ExternalReferenceNo.Equals(externalReference) && !line.Header.CreditMemo)
                .Items.ToList();


            var expences = purchaseList.Sum(purchase =>
            {
                var exchangeRate = GetExchangeRateForPurchase(purchase);
                return purchase.LineAmount * exchangeRate;
            });

            var profit = revenue - expences;

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

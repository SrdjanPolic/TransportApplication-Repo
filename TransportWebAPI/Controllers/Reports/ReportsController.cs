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
        public IActionResult GetExternalReferenceProfitReport()
        {
            var reportItems = new List<ProfitReportItem>();

            var externalReferences = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .GetList(header => !header.CreditMemo && !string.IsNullOrEmpty(header.ExternalReferenceNo))
                    .Items.Select(x => x.ExternalReferenceNo).Distinct().ToList();

            externalReferences.ForEach(externalReference =>
            {
                var reportProfitItem = GetExternalReferenceProfitReportItem(externalReference);
                reportItems.Add(reportProfitItem);
            });


            return Ok(reportItems);
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

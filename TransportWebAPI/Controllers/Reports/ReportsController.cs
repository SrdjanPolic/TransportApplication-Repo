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

        // GET: api/5/Datum
        [Route("[action]/{*travelOrder}")]
        [HttpGet]
        public IActionResult GetTravelOrderProfitReport(string travelOrder)
        {
            var salesList = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                .GetList(header => header.TravelOrder.Equals(travelOrder))
                .Items.ToList();

            var revenue = salesList.Sum(sale => sale.TotalAmountLocal);

            var purchaseList = _unitOfWork.GetRepository<PurchaseInvoiceLine>()
                .GetList(line => line.TravelOrder.Equals(travelOrder))
                .Items.ToList();

            
            var expences = purchaseList.Sum(purchase =>
            {
                var exchangeRate = GetExchangeRateForPurchase(purchase);
                return purchase.LineAmount* exchangeRate;
            });

            var profit = revenue - expences;

            var reportItem = new TravelOrderProfitReportItem
            {
                TravelOrder = travelOrder,
                Revenue = revenue,
                Expences = expences,
                Profit = profit
            };


            return Ok(reportItem);
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

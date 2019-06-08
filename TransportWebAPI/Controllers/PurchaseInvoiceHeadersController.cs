using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.PurchaseInvoice;
using Service.Data;
using Microsoft.EntityFrameworkCore;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseInvoiceHeadersController : ControllerBase
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public PurchaseInvoiceHeadersController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/PurchaseInvoiceHeaders
        [HttpGet]
        [ProducesResponseType(typeof(List<PurchaseInvoiceHeader>), 200)]
        public IActionResult GetPurchaseInvoiceHeaders()
        {
            try
            {
                var vendors = _unitOfWork.GetRepository<PurchaseInvoiceHeader>().GetList(orderBy: source => source.OrderByDescending(x => x.PostingDate)).Items;
                return Ok(vendors);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // GET: api/PurchaseInvoiceHeaders/5
        [HttpGet("{id}", Name = "GetInvoices")]
        public IActionResult GetPurchaseInvoiceHeader(int id)
        {
            try
            {
                var vendors = _unitOfWork.GetRepository<PurchaseInvoiceHeader>()
                    .Single(include: source => source.Include(x => x.Lines), predicate: x => x.Id == id);
                return Ok(vendors);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // POST: api/PurchaseInvoiceHeaders
        [HttpPost]
        public IActionResult PostPurchaseInvoiceHeader([FromBody]PurchaseInvoiceHeader purchaseInvoiceHeader)
        {
            //newly created
            if (purchaseInvoiceHeader.Id == 0)
            {
                _unitOfWork.GetRepository<PurchaseInvoiceHeader>().Add(purchaseInvoiceHeader);

                foreach(var purchaseInvoiceLine in purchaseInvoiceHeader.Lines)
                {
                    _unitOfWork.GetRepository<PurchaseInvoiceLine>().Add(purchaseInvoiceLine);
                }
            }
            //update
            else
            {
                _unitOfWork.Context.Entry(purchaseInvoiceHeader).State = EntityState.Modified;
            }

            //Delete for OrderItems
            foreach (var id in purchaseInvoiceHeader.DeletedInvoiceLineIds.Split(',').Where(x => x != ""))
            {
                var intId = int.Parse(id);
                _unitOfWork.GetRepository<PurchaseInvoiceLine>().Delete(intId);
            }

            _unitOfWork.SaveChanges();

            return CreatedAtRoute(routeName: "GetInvoices",
                                  routeValues: new { id = purchaseInvoiceHeader.Id },
                                  value: purchaseInvoiceHeader);
        }
    }
}

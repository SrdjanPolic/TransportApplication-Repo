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
        [HttpGet("{id}")]
        public IActionResult GetPurchaseInvoiceHeader(int id)
        {
            try
            {
                var vendors = _unitOfWork.GetRepository<PurchaseInvoiceHeader>()
                    .Single(include: source => source.Include(x => x.Lines)
                    .Include(header => header.Vendor).Include(header => header.Currency), predicate: x => x.Id == id);
                return Ok(vendors);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        //// PUT: api/PurchaseInvoiceHeaders/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPurchaseInvoiceHeader(int id, PurchaseInvoiceHeader purchaseInvoiceHeader)
        //{
        //    if (id != purchaseInvoiceHeader.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(purchaseInvoiceHeader).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PurchaseInvoiceHeaderExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/PurchaseInvoiceHeaders
        //[HttpPost]
        //public async Task<ActionResult<PurchaseInvoiceHeader>> PostPurchaseInvoiceHeader(PurchaseInvoiceHeader purchaseInvoiceHeader)
        //{
        //    _context.PurchaseInvoiceHeaders.Add(purchaseInvoiceHeader);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPurchaseInvoiceHeader", new { id = purchaseInvoiceHeader.Id }, purchaseInvoiceHeader);
        //}

        //private bool PurchaseInvoiceHeaderExists(int id)
        //{
        //    return _context.PurchaseInvoiceHeaders.Any(e => e.Id == id);
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.PurchaseInvoice;
using Service.Data;

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

        //// GET: api/PurchaseInvoiceHeaders/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<PurchaseInvoiceHeader>> GetPurchaseInvoiceHeader(int id)
        //{
        //    var purchaseInvoiceHeader = await _context.PurchaseInvoiceHeaders.FindAsync(id);

        //    if (purchaseInvoiceHeader == null)
        //    {
        //        return NotFound();
        //    }

        //    return purchaseInvoiceHeader;
        //}

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

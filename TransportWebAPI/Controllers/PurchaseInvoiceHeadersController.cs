using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.PurchaseInvoice;
using Service.Data;
using Microsoft.EntityFrameworkCore;
using DBLayerPOC.Infrastructure.Settings;

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
        public IActionResult GetPurchaseInvoiceHeaders()
        {
            try
            {
                var purchaseInvoiceHeaders = _unitOfWork.GetRepository<PurchaseInvoiceHeader>().
                    GetList(orderBy: source => source.OrderByDescending(x => x.PostingDate)).Items.ToList();

                return Ok(purchaseInvoiceHeaders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // GET: api/PurchaseInvoiceHeaders/5
        [HttpGet("{id}", Name = "GetInvoices")]
        public IActionResult GetPurchaseInvoiceHeader(int id)
        {
            try
            {
                var purchaseInvoiceHeader = _unitOfWork.GetRepository<PurchaseInvoiceHeader>()
                    .Single(include: source => source.Include(x => x.Lines), predicate: x => x.Id == id);

                if (purchaseInvoiceHeader == null)
                {
                    return NotFound();
                }

                return Ok(purchaseInvoiceHeader);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // POST: api/PurchaseInvoiceHeaders
        [HttpPost]
        public IActionResult PostPurchaseInvoiceHeader([FromBody]PurchaseInvoiceHeader purchaseInvoiceHeader)
        {
            try
            {
                if (purchaseInvoiceHeader == null)
                {
                    return BadRequest("PurchaseInvoiceHeader object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                Settings settingsObject = null; 
                //newly created
                if (purchaseInvoiceHeader.Id == 0)
                {
                    _unitOfWork.GetRepository<PurchaseInvoiceHeader>().Add(purchaseInvoiceHeader);

                    foreach (var purchaseInvoiceLine in purchaseInvoiceHeader.Lines)
                    {
                        _unitOfWork.GetRepository<PurchaseInvoiceLine>().Add(purchaseInvoiceLine);
                    }

                    settingsObject = _unitOfWork.GetRepository<Settings>()
                    .Single(x => x.ObjectName.ToLower().Equals("PurchaseInvoice") && x.Year == DateTime.Now.Year);
                }
                //update
                else
                {
                    foreach (var purchaseInvoiceLine in purchaseInvoiceHeader.Lines)
                    {
                        if (purchaseInvoiceLine.Id == 0)
                        {
                            _unitOfWork.GetRepository<PurchaseInvoiceLine>().Add(purchaseInvoiceLine);
                        }
                    }

                    _unitOfWork.Context.Entry(purchaseInvoiceHeader).State = EntityState.Modified;
                }

                //Delete for OrderItems
                if (!string.IsNullOrEmpty(purchaseInvoiceHeader.DeletedInvoiceLineIds))
                {
                    foreach (var id in purchaseInvoiceHeader.DeletedInvoiceLineIds.Split(',').Where(x => x != ""))
                    {
                        var intId = int.Parse(id);
                        _unitOfWork.GetRepository<PurchaseInvoiceLine>().Delete(intId);
                    }
                }

                if(settingsObject != null)
                {
                    settingsObject.LastUsedNumber++;
                    _unitOfWork.Context.Entry(settingsObject).State = EntityState.Modified;
                }

                _unitOfWork.SaveChanges();

                return CreatedAtRoute(routeName: "GetInvoices",
                                      routeValues: new { id = purchaseInvoiceHeader.Id },
                                      value: purchaseInvoiceHeader);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }
    }
}

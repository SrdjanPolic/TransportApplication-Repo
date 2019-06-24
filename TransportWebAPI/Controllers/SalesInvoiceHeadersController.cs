using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.SalesInvoice;
using Service.Data;
using Microsoft.EntityFrameworkCore;
using DBLayerPOC.Infrastructure.Settings;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesInvoiceHeadersController : ControllerBase
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public SalesInvoiceHeadersController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/SalesInvoiceHeaders
        [HttpGet]
        public IActionResult GetSalesInvoiceHeaders()
        {
            try
            {
                var SalesInvoiceHeaders = _unitOfWork.GetRepository<SalesInvoiceHeader>().
                    GetList(orderBy: source => source.OrderByDescending(x => x.PostingDate)).Items.ToList();

                return Ok(SalesInvoiceHeaders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // GET: api/SalesInvoiceHeaders/5
        [HttpGet("{id}", Name = "GetSalesInvoices")]
        public IActionResult GetSalesInvoiceHeader(int id)
        {
            try
            {
                var SalesInvoiceHeader = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                    .Single(include: source => source.Include(x => x.Lines), predicate: x => x.Id == id);

                if (SalesInvoiceHeader == null)
                {
                    return NotFound();
                }

                return Ok(SalesInvoiceHeader);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // POST: api/SalesInvoiceHeaders
        [HttpPost]
        public IActionResult PostSalesInvoiceHeader([FromBody]SalesInvoiceHeader SalesInvoiceHeader)
        {
            try
            {
                if (SalesInvoiceHeader == null)
                {
                    return BadRequest("SalesInvoiceHeader object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                Settings settingsObject = null; 
                //newly created
                if (SalesInvoiceHeader.Id == 0)
                {
                    _unitOfWork.GetRepository<SalesInvoiceHeader>().Add(SalesInvoiceHeader);

                    foreach (var SalesInvoiceLine in SalesInvoiceHeader.Lines)
                    {
                        _unitOfWork.GetRepository<SalesInvoiceLine>().Add(SalesInvoiceLine);
                    }

                    settingsObject = _unitOfWork.GetRepository<Settings>()
                    .Single(x => x.ObjectName.ToLower().Equals(Constants.SalesInvoiceObjectName) && x.Year == DateTime.Now.Year);
                }
                //update
                else
                {
                    foreach (var SalesInvoiceLine in SalesInvoiceHeader.Lines)
                    {
                        if (SalesInvoiceLine.Id == 0)
                        {
                            _unitOfWork.GetRepository<SalesInvoiceLine>().Add(SalesInvoiceLine);
                        }
                    }

                    _unitOfWork.Context.Entry(SalesInvoiceHeader).State = EntityState.Modified;
                }

                //Delete for OrderItems
                if (!string.IsNullOrEmpty(SalesInvoiceHeader.DeletedInvoiceLineIds))
                {
                    foreach (var id in SalesInvoiceHeader.DeletedInvoiceLineIds.Split(',').Where(x => x != ""))
                    {
                        var intId = int.Parse(id);
                        _unitOfWork.GetRepository<SalesInvoiceLine>().Delete(intId);
                    }
                }

                if(settingsObject != null)
                {
                    settingsObject.LastUsedNumber++;
                    _unitOfWork.Context.Entry(settingsObject).State = EntityState.Modified;
                }

                _unitOfWork.SaveChanges();

                return CreatedAtRoute(routeName: "GetSalesInvoices",
                                      routeValues: new { id = SalesInvoiceHeader.Id },
                                      value: SalesInvoiceHeader);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }
    }
}

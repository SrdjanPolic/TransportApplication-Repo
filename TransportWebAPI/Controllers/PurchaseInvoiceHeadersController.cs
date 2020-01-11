using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.PurchaseInvoice;
using Service.Data;
using Microsoft.EntityFrameworkCore;
using DBLayerPOC.Infrastructure.Settings;
using System.Text;

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
            var purchaseInvoiceHeaders = _unitOfWork.GetRepository<PurchaseInvoiceHeader>().
                GetList(include: source => source.Include(x => x.Vendor), orderBy: source => source.OrderByDescending(x => x.PostingDate)).Items.ToList();

            return Ok(purchaseInvoiceHeaders);
        }

        // GET: api/PurchaseInvoiceHeaders/5
        [HttpGet("{id}", Name = "GetPurchaseInvoices")]
        public IActionResult GetPurchaseInvoiceHeader(int id)
        {
            var purchaseInvoiceHeader = _unitOfWork.GetRepository<PurchaseInvoiceHeader>()
                .Single(include: source => source.Include(x => x.Lines), predicate: x => x.Id == id);

            if (purchaseInvoiceHeader == null)
            {
                return NotFound();
            }

            return Ok(purchaseInvoiceHeader);
        }

        // POST: api/PurchaseInvoiceHeaders
        [HttpPost]
        public IActionResult PostPurchaseInvoiceHeader([FromBody]PurchaseInvoiceHeader purchaseInvoiceHeader)
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
                    purchaseInvoiceLine.LastChangeDateTime = DateTime.UtcNow;
                    _unitOfWork.GetRepository<PurchaseInvoiceLine>().Add(purchaseInvoiceLine);
                }

                settingsObject = _unitOfWork.GetRepository<Settings>()
                .Single(x => x.ObjectName.ToLower().Equals(Constants.PurchaseInvoiceObjectName) && x.Year == DateTime.Now.Year);
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
                    else
                    {
                        _unitOfWork.Context.Entry(purchaseInvoiceLine).State = EntityState.Modified;
                    }

                    purchaseInvoiceLine.LastChangeDateTime = DateTime.UtcNow;
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

            if (settingsObject != null)
            {
                purchaseInvoiceHeader.InvoiceNo = GetInvoiceNumber(settingsObject);
                settingsObject.LastUsedNumber++;
                _unitOfWork.Context.Entry(settingsObject).State = EntityState.Modified;
            }

            purchaseInvoiceHeader.LastChangeDateTime = DateTime.UtcNow;

            IncreaseAllChangedDatetimesWithOneHour(purchaseInvoiceHeader);

            _unitOfWork.SaveChanges();

            return CreatedAtRoute(routeName: "GetPurchaseInvoices",
                                  routeValues: new { id = purchaseInvoiceHeader.Id },
                                  value: purchaseInvoiceHeader);
        }

        private void IncreaseAllChangedDatetimesWithOneHour(PurchaseInvoiceHeader header)
        {
            var properties = header.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(DateTime?) && property.Name != "LastChangeDateTime")
                {
                    var datum = property.GetValue(header, null);
                    if (((DateTime)datum).Hour == 23 && ((DateTime)datum).Minute == 0 && ((DateTime)datum).Second == 0)
                    {
                        property.SetValue(header, ((DateTime)property.GetValue(header, null)).AddHours(2), null);
                    }
                }
            }
        }

        private string GetInvoiceNumber(Settings settings)
        {
            return settings.Prefix + " - " + (settings.LastUsedNumber + 1).ToString();
        }
    }
}

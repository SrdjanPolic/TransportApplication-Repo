﻿using System;
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
            var SalesInvoiceHeaders = _unitOfWork.GetRepository<SalesInvoiceHeader>().
                GetList(include: source => source.Include(x => x.Customer), orderBy: source => source.OrderByDescending(x => x.PostingDate)).Items.ToList();

            return Ok(SalesInvoiceHeaders);
        }

        // GET:  api/SalesInvoiceHeaders/5
        [HttpGet("{id}", Name = "GetSalesInvoices")]
        public IActionResult GetSalesInvoiceHeader(int id)
        {
            var SalesInvoiceHeader = _unitOfWork.GetRepository<SalesInvoiceHeader>()
                .Single(include: source => source.Include(x => x.Lines), predicate: x => x.Id == id);

            if (SalesInvoiceHeader == null)
            {
                return NotFound();
            }

            return Ok(SalesInvoiceHeader);
        }

        // POST: api/SalesInvoiceHeaders
        [HttpPost]
        public IActionResult PostSalesInvoiceHeader([FromBody]SalesInvoiceHeader salesInvoiceHeader)
        {
            if (salesInvoiceHeader == null)
            {
                return BadRequest("SalesInvoiceHeader object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            Settings settingsObject = null;
            //newly created
            if (salesInvoiceHeader.Id == 0)
            {
                _unitOfWork.GetRepository<SalesInvoiceHeader>().Add(salesInvoiceHeader);

                foreach (var salesInvoiceLine in salesInvoiceHeader.Lines)
                {
                    _unitOfWork.GetRepository<SalesInvoiceLine>().Add(salesInvoiceLine);
                    salesInvoiceLine.LastChangeDateTime = DateTime.UtcNow;
                }

                settingsObject = _unitOfWork.GetRepository<Settings>()
                .Single(x => x.ObjectName.ToLower().Equals(SettingsConstants.SalesInvoiceObjectName) && x.Year == DateTime.Now.Year);
            }
            //update
            else
            {
                foreach (var salesInvoiceLine in salesInvoiceHeader.Lines)
                {
                    if (salesInvoiceLine.Id == 0)
                    {
                        _unitOfWork.GetRepository<SalesInvoiceLine>().Add(salesInvoiceLine);
                    }
                    else
                    {
                        _unitOfWork.Context.Entry(salesInvoiceLine).State = EntityState.Modified;
                    }

                    salesInvoiceLine.LastChangeDateTime = DateTime.UtcNow;
                }

                _unitOfWork.Context.Entry(salesInvoiceHeader).State = EntityState.Modified;
            }

            //Delete for OrderItems
            if (!string.IsNullOrEmpty(salesInvoiceHeader.DeletedInvoiceLineIds))
            {
                foreach (var id in salesInvoiceHeader.DeletedInvoiceLineIds.Split(',').Where(x => x != ""))
                {
                    var intId = int.Parse(id);
                    _unitOfWork.GetRepository<SalesInvoiceLine>().Delete(intId);
                }
            }

            if (settingsObject != null)
            {
                salesInvoiceHeader.InvoiceNo = GetInvoiceNumber(settingsObject);
                settingsObject.LastUsedNumber++;
                _unitOfWork.Context.Entry(settingsObject).State = EntityState.Modified;
            }

            salesInvoiceHeader.LastChangeDateTime = DateTime.UtcNow;

            IncreaseAllChangedDatetimesWithOneHour(salesInvoiceHeader);

            _unitOfWork.SaveChanges();

            return CreatedAtRoute(routeName: "GetSalesInvoices",
                                  routeValues: new { id = salesInvoiceHeader.Id },
                                  value: salesInvoiceHeader);
        }

        private void IncreaseAllChangedDatetimesWithOneHour(SalesInvoiceHeader header)
        {
            var properties = header.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(DateTime?) && property.Name != "LastChangeDateTime")
                {
                    var datum = property.GetValue(header, null);
                    if((((DateTime)datum).Hour == 23 || ((DateTime)datum).Hour == 22) && ((DateTime)datum).Minute == 0 && ((DateTime)datum).Second == 0)
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.Vendor;
using Service.Data;
using DBLayerPOC.Models;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRateController : Controller
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public ExchangeRateController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/CurrencyExchangeRate/5
        [HttpGet("{id}", Name = "GetCurrencyExchangeRate")]
        public IActionResult GetCurrencyExchangeRate(int id)
        {
            var currencyExchangeRate = _unitOfWork.GetRepository<CurrencyExchangeRate>().Single(x => x.Id == id);
            if (currencyExchangeRate == null)
            {
                return NotFound();
            }

            return Ok(currencyExchangeRate);
        }

        // GET: api/5
        [Route("[action]/{currencyId}")]
        [HttpGet]
        public IActionResult GetExchangeRatesForCurrency(int currencyId)
        {
            var currencyExchangeRates = _unitOfWork.GetRepository<CurrencyExchangeRate>()
                .GetList(x => x.CurrencyId == currencyId).Items.ToList();

            if (currencyExchangeRates == null)
            {
                return NotFound();
            }

            return Ok(currencyExchangeRates);
        }

        // GET: api/5/Datum
        [HttpGet("{currencyId}/{exchangeRateDatum}")]
        public IActionResult Get(int currencyId, DateTime exchangeRateDatum)
        {
            var currencyExchangeRate = _unitOfWork.GetRepository<CurrencyExchangeRate>()
                .Single(x => x.CurrencyId == currencyId
                            && DateTime.Compare(x.StartingDate.Date, exchangeRateDatum.Date) == 0);

            //no data on that Day, try to get last closest one
            if (currencyExchangeRate == null)
            {
                currencyExchangeRate = _unitOfWork.GetRepository<CurrencyExchangeRate>()
                                        .GetList().Items.Where(x => x.CurrencyId == currencyId
                                                                && DateTime.Compare(x.StartingDate.Date, exchangeRateDatum.Date) < 0)
                                        .OrderByDescending(y => y.StartingDate)
                                        .FirstOrDefault();
                //no exchange rate before, take last one
                if (currencyExchangeRate == null)
                {
                    _unitOfWork.GetRepository<CurrencyExchangeRate>()
                                        .GetList().Items.Where(x => x.CurrencyId == currencyId)
                                        .OrderByDescending(y => y.StartingDate)
                                        .FirstOrDefault();
                }
            }

            if (currencyExchangeRate == null)
            {
                return NotFound();
            }

            return Ok(currencyExchangeRate);
        }

        // POST: api/CurrencyExchangeRate
        [HttpPost]
        public IActionResult Post([FromBody]CurrencyExchangeRate exchangeRate)
        {
            if (exchangeRate == null)
            {
                return BadRequest("CurrencyExchangeRate object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            exchangeRate.LastChangeDateTime = DateTime.UtcNow;
            _unitOfWork.GetRepository<CurrencyExchangeRate>().Add(exchangeRate);
            _unitOfWork.SaveChanges();

            return CreatedAtRoute(routeName: "GetCurrencyExchangeRate",
                                  routeValues: new { id = exchangeRate.Id },
                                  value: exchangeRate);

        }

        // PUT: api/ExchangeRate/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CurrencyExchangeRate exchangeRate)
        {
            if (exchangeRate == null)
            {
                return BadRequest("CurrencyExchangeRate object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            var dbExchangeRate = _unitOfWork.GetRepository<CurrencyExchangeRate>().Single(x => x.Id == id);
            if (dbExchangeRate == null)
            {
                return NotFound();
            }

            exchangeRate.Id = id;
            exchangeRate.LastChangeDateTime = DateTime.Now;
            _unitOfWork.GetRepository<CurrencyExchangeRate>().Update(exchangeRate);
            _unitOfWork.SaveChanges();

            return NoContent();
        }
    }
}

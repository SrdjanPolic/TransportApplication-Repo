using System;
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

        //// GET: api/ExchangeRates
        //[HttpGet]
        //public IActionResult GetExchangeRates()
        //{

        //    var currencies = _unitOfWork.GetRepository<CurrencyExchangeRate>().
        //        GetList().Items.ToList();

        //    foreach (var e in currencies)
        //    {
        //        var currencyExchangeRate = _unitOfWork.GetRepository<CurrencyExchangeRate>()
        //            .GetList().Items.ToList().OrderByDescending(x => x.StartingDate).FirstOrDefault(x => x.CurrencyId == currency.Id);
        //        currency.CurrencyExchangeRates.Add(currencyExchangeRate);
        //    }

        //    return Ok(currencies);
        //}

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

        // GET: api/5/Datum
        [HttpGet("{currencyId}/{exchangeRateDatum}")]
        public IActionResult Get(int currencyId, DateTime exchangeRateDatum)
        {
            var currencyExchangeRate = _unitOfWork.GetRepository<CurrencyExchangeRate>()
                .Single(x => x.CurrencyId == currencyId
                            && x.StartingDate.Date.CompareTo(exchangeRateDatum.Date) == 0);

            //no data on that Day, try to get last closest one
            if (currencyExchangeRate == null)
            {
                currencyExchangeRate = _unitOfWork.GetRepository<CurrencyExchangeRate>()
                                        .GetList().Items.Where(x => x.CurrencyId == currencyId
                                                                && x.StartingDate.Date.CompareTo(exchangeRateDatum.Date) <= 0)
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
    }
}

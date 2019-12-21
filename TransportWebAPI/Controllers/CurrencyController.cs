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
    public class CurrencyController : Controller
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public CurrencyController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Currencies
        [HttpGet]
        public IActionResult GetCurrencies()
        {

            var currencies = _unitOfWork.GetRepository<Currency>().
                GetList().Items.ToList();

            foreach (var currency in currencies)
            {
                var currencyExchangeRate = _unitOfWork.GetRepository<CurrencyExchangeRate>()
                    .GetList().Items.ToList().OrderByDescending(x => x.StartingDate).FirstOrDefault(x => x.CurrencyId == currency.Id);
                currency.CurrencyExchangeRates.Add(currencyExchangeRate);
            }

            return Ok(currencies);
        }
    }
}

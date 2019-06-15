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
        [ProducesResponseType(typeof(List<Currency>), 200)]
        public IActionResult GetCurrencies()
        {
            try
            {
                var currencies = _unitOfWork.GetRepository<Currency>().GetList().Items;
                return Ok(currencies);
            }
            catch (Exception ex)
            {        
                return BadRequest();
            }
        }
    }
}

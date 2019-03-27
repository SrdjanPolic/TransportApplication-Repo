using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Data;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private IUnitOfWork<QuoteHeaderDbContext> _unitOfWork;
        ILogger _Logger;

        public CustomerController(IUnitOfWork<QuoteHeaderDbContext> unitOfWork, ILoggerFactory loggerFactory)
        {
            _unitOfWork = unitOfWork;
            _Logger = loggerFactory.CreateLogger(nameof(CustomerController));
        }

        // GET: api/Customer
        [HttpGet]
        [ProducesResponseType(typeof(List<Customer>), 200)]
        public async Task<ActionResult> Get()
        {
            try
            {
                var customers = _unitOfWork.GetRepository<Customer>().GetList(size:99999999).Items;
                return Ok(customers);
            }
            catch(Exception ex)
            {
                _Logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(typeof(List<Customer>), 200)]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var customer = _unitOfWork.GetRepository<Customer>().Single(x => x.Id == id);
                return Ok(customer);
            }
            catch (Exception exp)
            {
                _Logger.LogError(exp.Message);
                return BadRequest();
            }
        }

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

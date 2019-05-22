using System;
using System.Collections.Generic;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Data;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : Controller
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;
        ILogger _Logger;

        public CustomersController(IUnitOfWork<AppDbContext> unitOfWork, ILoggerFactory loggerFactory)
        {
            _unitOfWork = unitOfWork;
            _Logger = loggerFactory.CreateLogger(nameof(CustomersController));
        }

        // GET: api/Customers
        [HttpGet]
        [ProducesResponseType(typeof(List<Customer>), 200)]
        public IActionResult Get()
        {
            try
            {
                _Logger.LogError("log enter");
                var customers = _unitOfWork.GetRepository<Customer>().GetList(size:10000).Items;
                return Ok(customers);
            }
            catch(Exception ex)
            {
                _Logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(typeof(List<Customer>), 200)]
        public IActionResult Get(int id)
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

        // POST: api/Customers
        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                _unitOfWork.GetRepository<Customer>().Add(customer);
                _unitOfWork.SaveChanges();

                return CreatedAtRoute(routeName: "Get",
                                      routeValues: new { id = customer.Id },
                                      value: customer);
            }
            catch(Exception ex)
            {
                _Logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public  IActionResult Put(int id, [FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                customer.Id = id;
                _unitOfWork.GetRepository<Customer>().Update(customer);
                _unitOfWork.SaveChanges();

                return Ok();
            }
            catch (Exception exp)
            {
                _Logger.LogError(exp.Message);
                return BadRequest();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Models;
using Microsoft.AspNetCore.Authorization;
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

        public CustomersController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Customers
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            var customers = _unitOfWork.GetRepository<Customer>()
                .GetList(orderBy: source => source.OrderByDescending(x => x.LastChangeDateTime)).Items.ToList();
            return Ok(customers);
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var customer = _unitOfWork.GetRepository<Customer>().Single(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // POST: api/Customers
        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customer object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            customer.LastChangeDateTime = DateTime.UtcNow;
            _unitOfWork.GetRepository<Customer>().Add(customer);
            _unitOfWork.SaveChanges();

            return CreatedAtRoute(routeName: "Get",
                                  routeValues: new { id = customer.Id },
                                  value: customer);

        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customer object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            var dbCustomer = _unitOfWork.GetRepository<Customer>().Single(x => x.Id == id);
            if (dbCustomer == null)
            {
                return NotFound();
            }

            customer.Id = id;
            customer.LastChangeDateTime = DateTime.Now;
            _unitOfWork.GetRepository<Customer>().Update(customer);
            _unitOfWork.SaveChanges();

            return NoContent();
        }
    }
}

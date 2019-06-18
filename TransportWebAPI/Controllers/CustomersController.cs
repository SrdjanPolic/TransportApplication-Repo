using System;
using System.Collections.Generic;
using System.Linq;
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

        public CustomersController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Customers
        [HttpGet]
        public IActionResult Get()
        {
            try
            { 
                var customers = _unitOfWork.GetRepository<Customer>()
                    .GetList(orderBy: source => source.OrderByDescending(x => x.LastChangeDate)).Items.ToList();
                return Ok(customers);
            }
            catch(Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                var customer = _unitOfWork.GetRepository<Customer>().Single(x => x.Id == id);
                if(customer == null)
                {
                    return NotFound();
                }

                return Ok(customer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // POST: api/Customers
        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            try
            {
                if (customer == null)
                {
                    return BadRequest("Customer object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                customer.LastChangeDate = DateTime.Now;
                _unitOfWork.GetRepository<Customer>().Add(customer);
                _unitOfWork.SaveChanges();

                return CreatedAtRoute(routeName: "Get",
                                      routeValues: new { id = customer.Id },
                                      value: customer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public  IActionResult Put(int id, [FromBody] Customer customer)
        {
            try
            {
                if(customer == null)
                {
                    return BadRequest("Customer object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                var dbCustomer = _unitOfWork.GetRepository<Customer>().Single(x => x.Id == id);
                if(dbCustomer == null)
                {
                    return NotFound();
                }

                customer.Id = id;
                customer.LastChangeDate = DateTime.Now;
                _unitOfWork.GetRepository<Customer>().Update(customer);
                _unitOfWork.SaveChanges();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }
    }
}

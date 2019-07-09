using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.Driver;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Data;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public DriversController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Drivers
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var drivers = _unitOfWork.GetRepository<Driver>()
                    .GetList().Items.ToList();
                return Ok(drivers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // GET: api/Drivers/5
        [HttpGet("{id}", Name = "GetDriver")]
        public IActionResult Get(int id)
        {
            try
            {
                var drivers = _unitOfWork.GetRepository<Driver>().Single(x => x.Id == id);
                if (drivers == null)
                {
                    return NotFound();
                }

                return Ok(drivers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // POST: api/Drivers
        [HttpPost]
        public IActionResult Post([FromBody]Driver driver)
        {
            try
            {
                if (driver == null)
                {
                    return BadRequest("Driver object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                _unitOfWork.GetRepository<Driver>().Add(driver);
                _unitOfWork.SaveChanges();

                return CreatedAtRoute(routeName: "GetDriver",
                                      routeValues: new { id = driver.Id },
                                      value: driver);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // PUT: api/Drivers/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Driver driver)
        {
            try
            {
                if (driver == null)
                {
                    return BadRequest("Driver object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                var dbCustomer = _unitOfWork.GetRepository<Driver>().Single(x => x.Id == id);
                if (dbCustomer == null)
                {
                    return NotFound();
                }

                driver.Id = id;
                _unitOfWork.GetRepository<Driver>().Update(driver);
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

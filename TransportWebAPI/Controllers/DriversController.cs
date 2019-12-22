using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.Driver;
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
            var drivers = _unitOfWork.GetRepository<Driver>()
                .GetList().Items.ToList();
            return Ok(drivers);
        }

        // GET: api/Drivers/5
        [HttpGet("{id}", Name = "GetDriver")]
        public IActionResult Get(int id)
        {
                var drivers = _unitOfWork.GetRepository<Driver>().Single(x => x.Id == id);
                if (drivers == null)
                {
                    return NotFound();
                }

            return Ok(drivers);
        }

        // POST: api/Drivers
        [HttpPost]
        public IActionResult Post([FromBody]Driver driver)
        {

            if (driver == null)
            {
                return BadRequest("Driver object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            driver.LastChangeDateTime = DateTime.UtcNow;
            _unitOfWork.GetRepository<Driver>().Add(driver);
            _unitOfWork.SaveChanges();

            return CreatedAtRoute(routeName: "GetDriver",
                                  routeValues: new { id = driver.Id },
                                  value: driver);
        }

        // PUT: api/Drivers/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Driver driver)
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
            driver.LastChangeDateTime = DateTime.UtcNow;
            _unitOfWork.GetRepository<Driver>().Update(driver);
            _unitOfWork.SaveChanges();

            return NoContent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.Vehicle;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Data;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public VehiclesController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Vehicles
        [HttpGet]
        public IActionResult Get()
        {
            var vehicles = _unitOfWork.GetRepository<Vehicle>()
                .GetList().Items.ToList();
            return Ok(vehicles);
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}", Name = "GetVehicle")]
        public IActionResult Get(int id)
        {

            var vehicles = _unitOfWork.GetRepository<Vehicle>().Single(x => x.Id == id);
            if (vehicles == null)
            {
                return NotFound();
            }

            return Ok(vehicles);
        }

        // POST: api/Vehicles
        [HttpPost]
        public IActionResult Post([FromBody]Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return BadRequest("Vehicle object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            _unitOfWork.GetRepository<Vehicle>().Add(vehicle);
            _unitOfWork.SaveChanges();

            return CreatedAtRoute(routeName: "GetVehicle",
                                  routeValues: new { id = vehicle.Id },
                                  value: vehicle);
        }

        // PUT: api/Vehicles/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return BadRequest("Vehicle object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            var dbCustomer = _unitOfWork.GetRepository<Vehicle>().Single(x => x.Id == id);
            if (dbCustomer == null)
            {
                return NotFound();
            }

            vehicle.Id = id;
            _unitOfWork.GetRepository<Vehicle>().Update(vehicle);
            _unitOfWork.SaveChanges();

            return NoContent();
        }
    }
}

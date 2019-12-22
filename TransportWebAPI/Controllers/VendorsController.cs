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

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorsController : Controller
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public VendorsController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Vendors
        [HttpGet]
        public IActionResult GetVendors()
        {

            var vendors = _unitOfWork.GetRepository<Vendor>().
                GetList(orderBy: source => source.OrderByDescending(x => x.LastChangeDate)).Items.ToList();
            return Ok(vendors);
        }

        // GET: api/Vendors/5
        [HttpGet("{id}", Name = "GetVendor")]
        public IActionResult GetVendor(int id)
        {

            var vendor = _unitOfWork.GetRepository<Vendor>().Single(x => x.Id == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return Ok(vendor);
        }

        // PUT: api/Vendors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendor(int id, [FromBody] Vendor vendor)
        {
            if (vendor == null)
            {
                return BadRequest("Vendor object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            var dbVendor = _unitOfWork.GetRepository<Vendor>().Single(x => x.Id == id);
            if (dbVendor == null)
            {
                return NotFound();
            }

            vendor.Id = id;
            vendor.LastChangeDateTime = DateTime.UtcNow;
            vendor.LastChangeDate = DateTime.Now;
            _unitOfWork.GetRepository<Vendor>().Update(vendor);
            _unitOfWork.SaveChanges();

            return NoContent();
        }

        // POST: api/Vendors
        [HttpPost]
        public IActionResult Post([FromBody] Vendor vendor)
        {
            if (vendor == null)
            {
                return BadRequest("Vendor object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            vendor.LastChangeDateTime = DateTime.UtcNow;
            _unitOfWork.GetRepository<Vendor>().Add(vendor);
            _unitOfWork.SaveChanges();

            return CreatedAtRoute(routeName: "GetVendor",
                                  routeValues: new { id = vendor.Id },
                                  value: vendor);
        }
    }
}

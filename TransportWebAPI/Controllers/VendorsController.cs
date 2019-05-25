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
        [ProducesResponseType(typeof(List<Vendor>), 200)]
        public IActionResult GetVendors()
        {
            try
            {
                var vendors = _unitOfWork.GetRepository<Vendor>().GetList(orderBy: source => source.OrderByDescending(x => x.LastChangeDate)).Items;
                return Ok(vendors);
            }
            catch (Exception ex)
            {        
                return BadRequest();
            }
        }

        // GET: api/Vendors/5
        [HttpGet("{id}", Name = "GetVendor")]
        [ProducesResponseType(typeof(List<Vendor>), 200)]
        public IActionResult GetVendor(int id)
        {
            try
            {
                var vendor = _unitOfWork.GetRepository<Vendor>().Single(x => x.Id == id);
                return Ok(vendor);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT: api/Vendors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendor(int id, [FromBody] Vendor vendor)
        {
            if (id != vendor.Id)
            {
                return BadRequest();
            }
            try
            {
                _unitOfWork.GetRepository<Vendor>().Update(vendor);
                _unitOfWork.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vendors
        [HttpPost]
        public IActionResult Post([FromBody] Vendor vendor)
        {
            try
            {
                _unitOfWork.GetRepository<Vendor>().Add(vendor);
                _unitOfWork.SaveChanges();

                return CreatedAtRoute(routeName: "GetVendor",
                                      routeValues: new { id = vendor.Id },
                                      value: vendor);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        private bool VendorExists(int id)
        {
            return _unitOfWork.GetRepository<Vendor>().GetList().Items.Any(e => e.Id == id);
        }
    }
}

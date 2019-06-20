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
using DBLayerPOC.Infrastructure.Settings;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : Controller
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public SettingsController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Settings/PurchaseInvoice
        [HttpGet("{objectName}", Name = "GetSettings")]
        public IActionResult Get(string objectName)
        {
            try
            {
                var settings = _unitOfWork.GetRepository<Settings>()
                    .Single(x => x.ObjectName.ToLower().Equals(objectName.ToLower()) && x.Year == DateTime.Now.Year);
                if (settings == null)
                {
                    return NotFound();
                }

                return Ok(settings);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }
    }
}

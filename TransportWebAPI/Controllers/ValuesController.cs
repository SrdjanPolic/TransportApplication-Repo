﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Data;
using Newtonsoft.Json;
using System.IO;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUnitOfWork< QuoteHeaderDbContext> _unitOfWork;
        public ValuesController(IUnitOfWork<QuoteHeaderDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //return new string[] { "value1", "value2" };
            //var items = _unitOfWork.GetRepository<TransportOffer>().
            //    GetList(predicate: x => x.Id >= 3452 && x.Id <= 9744,
            //    size: 9999999).Items;

            var items = _unitOfWork.GetRepository<QuoteHeader>().
               GetList(include: source =>
                    source.Include(x => x.QuoteLines).Include(header => header.Customer), size: 99999999, predicate: x => x.Id >= 0 && x.Id <= 9744).Items;


            List<string> strings = new List<string>();
            foreach (QuoteHeader offer in items)
            {
                strings.Add(offer.Header + "\n");
                foreach (QuoteLine route in offer.QuoteLines)
                {
                    strings.Add("   " + route.From + "    " + route.To);
                }
            }
            return strings;

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post(QuoteHeader header)
        {
            _unitOfWork.GetRepository<QuoteHeader>().Add(header);
            var routeList = new List<QuoteLine>
            {
                new QuoteLine
                {
                    From = Path.GetRandomFileName(),
                    To = Path.GetRandomFileName(),
                    QuoteHeader = header
                },
                new QuoteLine
                {
                    From = Path.GetRandomFileName(),
                    To = Path.GetRandomFileName(),
                    QuoteHeader = header
                },
                new QuoteLine
                {
                    From = Path.GetRandomFileName(),
                    To = Path.GetRandomFileName(),
                    QuoteHeader = header
                },
                new QuoteLine
                {
                    From = Path.GetRandomFileName(),
                    To = Path.GetRandomFileName(),
                    QuoteHeader = header
                },
                new QuoteLine
                {
                    From = Path.GetRandomFileName(),
                    To = Path.GetRandomFileName(),
                    QuoteHeader = header
                },
                new QuoteLine
                {
                    From = Path.GetRandomFileName(),
                    To = Path.GetRandomFileName(),
                    QuoteHeader = header
                },
                new QuoteLine
                {
                    From = Path.GetRandomFileName(),
                    To = Path.GetRandomFileName(),
                    QuoteHeader = header
                },
                new QuoteLine
                {
                    From = Path.GetRandomFileName(),
                    To = Path.GetRandomFileName(),
                    QuoteHeader = header
                }
            };

            _unitOfWork.GetRepository<QuoteLine>().Add(routeList);

            _unitOfWork.SaveChanges();

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

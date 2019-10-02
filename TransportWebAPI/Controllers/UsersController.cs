﻿using System;
using System.Collections.Generic;
using System.Linq;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Data;

namespace TransportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public UsersController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Customers
        [HttpGet, Authorize]
        public IActionResult Get([FromBody]LoginModel loggedUser)
        {
            try
            {
                if (loggedUser == null || !loggedUser.IsAdmin)
                {
                    return BadRequest(401);
                }
                var users = _unitOfWork.GetRepository<LoginModel>()
                    .GetList().Items.ToList();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get"), Authorize]
        public IActionResult Get(int id, LoginModel loggedUser)
        {
            try
            {
                if (loggedUser.IsAdmin)
                {
                    var user = _unitOfWork.GetRepository<LoginModel>().Single(x => x.Id == id);
                    if (user == null)
                    {
                        return NotFound();
                    }

                    return Ok(user);
                }

                return BadRequest(401);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // POST: api/User
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] LoginModel userToInsert, LoginModel loggedUser)
        {
            try
            {
                if(loggedUser == null || !loggedUser.IsAdmin)
                {
                    return BadRequest(401);
                }
                if (userToInsert == null)
                {
                    return BadRequest("User object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                
                _unitOfWork.GetRepository<LoginModel>().Add(userToInsert);
                _unitOfWork.SaveChanges();

                return CreatedAtRoute(routeName: "Get",
                                      routeValues: new { id = userToInsert.Id },
                                      value: userToInsert);
            }
            catch (Exception ex)
            {
                return StatusCode(500, string.Format("Internal server error + {0}" + ex.Message));
            }
        }

        // PUT: api/User/5
        [HttpPut("{id}"), Authorize]
        public IActionResult Put(int id, [FromBody] LoginModel userToChange, LoginModel loggedUser)
        {
            try
            {
                if (loggedUser == null || !loggedUser.IsAdmin)
                {
                    return BadRequest(401);
                }

                if (userToChange == null)
                {
                    return BadRequest("Customer object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                var dbUser = _unitOfWork.GetRepository<LoginModel>().Single(x => x.Id == id);
                if (dbUser == null)
                {
                    return NotFound();
                }

                userToChange.Id = id;
                //customer.LastChangeDate = DateTime.Now;
                _unitOfWork.GetRepository<LoginModel>().Update(userToChange);
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

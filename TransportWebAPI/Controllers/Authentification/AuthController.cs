using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DBLayerPOC.Infrastructure;
using DBLayerPOC.Infrastructure.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Service.Data;

namespace TransportWebAPI.Controllers.Authentification
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        public AuthController(IUnitOfWork<AppDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // GET api/values
        [HttpPost]
        public IActionResult Login([FromBody]LoginModel user)
        {
            if (user == null)   
            {
                return BadRequest("Invalid client request");
            }

            var users = _unitOfWork.GetRepository<LoginModel>().
                    GetList().Items.ToList();
            if(users.Any(x => x.Password.Equals(user.Password) && x.Username.Equals(user.Username)))
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:56515",
                    audience: "http://localhost:56515",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(15),
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
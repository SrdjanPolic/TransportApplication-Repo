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
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Service.Data;

namespace TransportWebAPI.Controllers.Authentification
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IUnitOfWork<AppDbContext> _unitOfWork;

        private IEmailSendingClient _emailSendingClient;

        public AuthController(IUnitOfWork<AppDbContext> unitOfWork, EmailSendingClient emailSendingClient)
        {
            _unitOfWork = unitOfWork;
            _emailSendingClient = emailSendingClient;
        }


        // GET api/values
        [HttpPost]
        public IActionResult Login([FromBody]LoginModel user)
        {
            if (user == null)
            {
                _emailSendingClient.SendLogEmail("Invalid client request");
                return BadRequest("Invalid client request");
            }

            var users = _unitOfWork.GetRepository<LoginModel>().
                        GetList().Items.ToList();
            if (users.Any(x => x.Password.Equals(user.Password) && x.Username.Equals(user.Username) && !x.IsInactive))
            {
                var loggedUser = users.FirstOrDefault(x => x.Password.Equals(user.Password) && x.Username.Equals(user.Username));
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
               // _emailSendingClient.SendLogEmail($"Logged user: {loggedUser.Name} {"  "} {loggedUser.Username} {"  "} {DateTime.UtcNow}");
                return Ok(new { Token = tokenString, loggedUser.IsAdmin, loggedUser.Id });
            }
            else
            {
                _emailSendingClient.SendLogEmail($"Attempt of unautorhized access: {user.Username}, {"  "} {user.Password} {"  "} {DateTime.UtcNow}");
                return Unauthorized();
            }
        }
    }
}
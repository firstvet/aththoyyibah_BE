using Ath_Thoyyibah_BE.Models.DTO;
using Ath_Thoyyibah_BE.Services.AuthService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System.Net.Mail;
using System.Reflection.PortableExecutable;
using System.Security.Claims;

namespace Ath_Thoyyibah_BE.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;
        private readonly IConfiguration _configuration;
        Response response = new Response();
        public AuthController(IAuthService service,   IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult<Response>> RegisterUser([FromBody] DTOUserRegister user)
        {
            response.requestTime = DateTime.Now;
            response = await _service.Register(user, response);

            return response;
        }

 
        [HttpPost]
        public async Task<ActionResult<Response>> Login([FromBody] UserLogin user)
        {
            response.requestTime = DateTime.Now;
            response = await _service.Login(user, response);
            if (response.code != "200")
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpGet("me"), Authorize()]
        public async Task<ActionResult<Response>> Me()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            response.requestTime = DateTime.Now;

            return response;
        }


    }
}

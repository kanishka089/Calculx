using CalculX.AuthService.Models;
using CalculX.AuthService.Services;
using CalculX.AuthService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculX.AuthService.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthorizationService _service;
        public AuthController(IAuthorizationService service)
        {
            _service = service;
        }
        [HttpPost]
        [Route("isAuthorized")]
        public async Task<IActionResult> IsAuthorized([FromBody] Auth auth)
        {
            _service.CheckAuthorization(auth);
            return Ok("result");
        }
    }
}

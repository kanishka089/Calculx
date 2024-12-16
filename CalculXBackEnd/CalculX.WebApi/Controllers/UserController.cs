using AutoMapper;
using CalculX.WebApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserService.Entities;
using UserService.Models;
using UserService.Services.Interfaces;

namespace CalculX.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public UserController(IUserService userService, IMapper mapper, IConfiguration configuration)
        {
            _userService = userService;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserModel model)
        {
            var user = _mapper.Map<User>(model);
            await _userService.AddUserAsync(user, model.Password);
            return Ok("User registered successfully.");
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel request)
        {
            var user = await _userService.LoginAsync(request.Email, request.Password);
            if (user == null) return Unauthorized("Invalid credentials.");
            var jwtGenerator = new JWTGenerator(_configuration);
            var token = jwtGenerator.GenerateJwtToken(user.Id,user.TenantId);
            return Ok(new { Message = "Login successful.", Token = token });
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] string email)
        {
            var token = await _userService.GeneratePasswordResetTokenAsync(email);
            if (token == null) return NotFound("User not found.");

            return Ok(new { ResetToken = token });
        }

        [HttpGet("get")]
        public async Task<IActionResult>Get(int Id)
        {
           return Ok(await _userService.Get(Id));
        }

    }
}

using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TenantService.Entities;
using TenantService.Models;
using TenantService.Services.Interfaces;

namespace CalculX.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITenantService _service;
        public TenantController(IMapper mapper,ITenantService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpPost("add")]
        [Authorize]
        public async Task<IActionResult> Add([FromBody] TenantModel model)
        {            
            await _service.AddAsync(_mapper.Map<Tenant>(model));
            return Ok("Tenant Added successfully.");
        }
        
        [HttpGet]
        public async Task<IActionResult>Get(int id)
        {
          return Ok( await _service.GetAsync(id));
        }

    }
}

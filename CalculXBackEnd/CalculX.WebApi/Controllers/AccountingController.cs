using AccountingService.Entities;
using AccountingService.Models;
using AccountingService.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace CalculX.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingController : ControllerBase
    {
        private readonly IAccountingService _accountingService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public AccountingController(IAccountingService accountingService, IMapper mapper, IConfiguration configuration)
        {
            _accountingService = accountingService;
            _mapper = mapper;
            _configuration = configuration;
        }
        [HttpPost("add-account")]
        public async Task<IActionResult> Register([FromBody] AccountModel model)
        {
            var account = _mapper.Map<Account>(model);
            await _accountingService.AddAccountAsync(account);
            return Ok("Account added successfully.");
        }
    }
}

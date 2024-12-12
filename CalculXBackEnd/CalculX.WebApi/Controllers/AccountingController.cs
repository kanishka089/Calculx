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
        public AccountingController(IAccountingService accountingService, IMapper mapper)
        {
            _accountingService = accountingService;
            _mapper = mapper;
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

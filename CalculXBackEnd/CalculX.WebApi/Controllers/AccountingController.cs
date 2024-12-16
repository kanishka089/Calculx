using AccountingService.Entities;
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
        [HttpGet("get-account/{accountNumber}")]
        public async Task<IActionResult> GetAccountById(string accountNumber)
        {
            try
            {
                await _accountingService.GetDetailsByAccountNumberAsync(accountNumber);
                return Ok("Account added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred", error = ex.Message });
            }
        }

        [HttpPost("add-account")]
        public async Task<IActionResult> CreateAccount([FromBody] Account accountModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var account = _mapper.Map<Account>(accountModel);
                await _accountingService.AddAccountAsync(account);
                return Ok("Account added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred", error = ex.Message });
            }
        }

        [HttpPost("update-account")]
        public async Task<IActionResult> UpdateAccount(string accountNumber, [FromBody] Account accountModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var account = _mapper.Map<Account>(accountModel);
                await _accountingService.UpdateAccountAsync(account);
                return Ok("Account added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred", error = ex.Message });
            }
        }

        [HttpPost("delete-account")]
        public async Task<IActionResult> DeleteAccount([FromBody] Account accountModel)
        {
            try
            {
                var account = _mapper.Map<Account>(accountModel);
                await _accountingService.DeleteAccountAsync(account);
                return Ok("Account added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred", error = ex.Message });
            }
        }
    }
}

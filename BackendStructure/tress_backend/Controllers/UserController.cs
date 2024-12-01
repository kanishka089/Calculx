using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Entities;
using UserService.Entities.Dto;
using UserService.Services.Interfaces;

namespace tress_backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserService _userService) : ControllerBase
{

    [HttpGet("{id}", Name = "GetUserById")]
    public async Task<IActionResult> GetUserById(string id)
    {
        var user = await _userService.GetUserByIdAsync(id);
        if (user == null)
        {
            return NotFound();  
        }
        return Ok(user);
    }

    [HttpGet(Name = "GetAllUsers")]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetAllUsers()
    {
        var users = await _userService.GetAllUsersAsync();
        if (users == null || !users.Any())
        {
            return NotFound();
        }

        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> AddUser([FromBody] UserDto dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        var createdUser = await _userService.CreateUserAsync(dto);
        return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(string id, [FromBody] UserDto userUpdateDto)
    {
        if (userUpdateDto == null)
        {
            return BadRequest();
        }
        var updatedUser = await _userService.UpdateUserAsync(id, userUpdateDto);
        if (updatedUser == null)
        {
            return NotFound();
        }
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(string id)
    {
        var deletedUser = await _userService.DeleteUserByIdAsync(id);
        if (deletedUser == null)
        {
            return NotFound();
        }
        return Ok();
    }
}

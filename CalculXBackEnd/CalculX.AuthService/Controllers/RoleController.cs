using CalculX.AuthService.Models;
using CalculX.AuthService.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

/*[Authorize(Roles = "Admin")] */// Restrict access to Admin users
[ApiController]
//[Authorize(Roles = "Admin")]
[Route("api/[controller]")]
public class RoleController : ControllerBase
{
    private readonly RoleManager<ApplicationRole> _roleManager;
    private readonly UserManager<ApplicationUser> _userManager;

    public RoleController(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
    {
        _roleManager = roleManager;
        _userManager = userManager;
    }

    // 1. Create a new role
    [HttpPost("create")]
    public async Task<IActionResult> CreateRole([FromBody] string roleName)
    {
        if (string.IsNullOrWhiteSpace(roleName))
            return BadRequest("Role name cannot be empty.");

        var result = await _roleManager.CreateAsync(new ApplicationRole { Name = roleName,Description = ""});
        if (result.Succeeded)
            return Ok($"Role '{roleName}' created successfully.");

        return BadRequest(result.Errors);
    }

    // 2. Assign a role to a user
    [HttpPost("assign")]
    public async Task<IActionResult> AssignRoleToUser([FromBody] AssignRoleViewModel model)
    {
        var user = await _userManager.FindByIdAsync(model.UserId);
        if (user == null)
            return NotFound("User not found.");

        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
        if (result.Succeeded)
            return Ok($"User '{user.UserName}' assigned to role '{model.RoleName}'.");

        return BadRequest(result.Errors);
    }

    // 3. Remove a role from a user
    [HttpPost("remove")]
    public async Task<IActionResult> RemoveRoleFromUser([FromBody] AssignRoleViewModel model)
    {
        var user = await _userManager.FindByIdAsync(model.UserId);
        if (user == null)
            return NotFound("User not found.");

        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
        if (result.Succeeded)
            return Ok($"User '{user.UserName}' removed from role '{model.RoleName}'.");

        return BadRequest(result.Errors);
    }

    // 4. List all roles
    [HttpGet("list")]
    public async Task<IActionResult> ListRoles()
    {
        var roles = await _roleManager.Roles.ToListAsync();
        return Ok(roles);
    }

    // 5. Get users in a specific role
    [HttpGet("users/{roleName}")]
    public async Task<IActionResult> GetUsersInRole(string roleName)
    {
        var usersInRole = await _userManager.GetUsersInRoleAsync(roleName);
        return Ok(usersInRole);
    }
}
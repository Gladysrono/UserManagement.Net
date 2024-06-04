using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserManagement.Net.Service.Interfaces;
using UserManagement.Net.API.Models;

namespace UserManagement.Net.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Username))
            {
                return BadRequest("Invalid registration request");
            }

#pragma warning disable CS8604 // Possible null reference argument.
            await _userService.RegisterUserAsync(request.Username, password: request.Password, request.Email);
#pragma warning restore CS8604 // Possible null reference argument.
            return Ok(new { message = "User registered successfully" });
        }

        // Other methods...
    }
}

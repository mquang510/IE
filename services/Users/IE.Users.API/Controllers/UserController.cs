using IE.Users.Application.DTOs;
using IE.Users.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IE.Users.API.Controllers
{

    [ApiController]
    [Route("api/user")]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpPost(Name = "Create")]
        [Route("user/create")]
        public async Task<ActionResult> Create()
        {
            await _userService.CreateUserAsync(new UserDto());
            return null;
        }

        [HttpGet(Name = "GetAll")]
        [Route("getall")]
        public async Task<ActionResult> GetAll()
        {
            var users = await _userService.GetAllUserAsync();
            return Ok(users);
        }
    }
}

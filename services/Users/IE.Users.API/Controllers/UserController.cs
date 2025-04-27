using Azure;
using IE.Shared.Constants;
using IE.Users.API.Helper;
using IE.Users.Application.DTOs;
using IE.Users.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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
            var user = await _userService.CreateUserAsync(new UserDto());
            return Ok(user);
        }

        [HttpPost(Name = "GetAll")]
        [Route("getall")]
        public async Task<ActionResult> GetAll()
        {
            var users = await _userService.GetAllUserAsync();
            return Ok(users);
        }


        [HttpPost(Name = "Login")]
        [Route("login")]
        public async Task<ActionResult> Login([FromBody] UserDto userDto)
        {
            ActionResult response = Unauthorized();
            var user = await _userService.GetUserLoginAsync(userDto.Email, userDto.Password);
            if (user != null)
            {
                try
                {
                    var tokenString = JwtHelper.GenerateJSONWebToken(user);
                    response = Ok(new { token = tokenString });
                }
                catch
                {

                }

            }
            return response;
        }

        [HttpPost(Name = "Me")]
        [Route("me")]
        public async Task<ActionResult> Me([FromBody] UserDto userDto)
        {
            var email = User.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Email);
            var user = await _userService.GetUserLoginAsync(userDto.Email, userDto.Password);
            return Ok(user);
        }
    }
}

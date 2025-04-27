using Azure;
using IE.Shared.Constants;
using IE.Users.API.Helper;
using IE.Users.API.Model;
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


        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login([FromBody] UserLoginModel userDto)
        {
            ActionResult response = Unauthorized();
            var user = await _userService.GetUserLoginAsync(userDto.Email, userDto.Password);
            if (user != null)
            {
                var tokenString = JwtHelper.GenerateJSONWebToken(user);
                return Ok(new { token = tokenString });
            }
            return Ok(response);
        }

        [HttpGet(Name = "Me")]
        [Route("me")]
        public async Task<ActionResult> Me()
        {
            var email = User.Claims.FirstOrDefault(x => x.Type == JwtAppConstants.ClaimEmail);
            if (email != null)
            {
                var user = await _userService.GetUserByEmailAsync(email.Value);
                return Ok(user);
            }
            ActionResult response = Unauthorized();
            return Ok(response);
        }
    }
}

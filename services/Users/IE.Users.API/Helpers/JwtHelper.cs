using IE.Shared.Constants;
using IE.Users.Application.DTOs;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IE.Users.API.Helper
{
    public static class JwtHelper
    {
        public static string GenerateJSONWebToken(UserDto userDto)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtAppConstants.PrivateKey ?? string.Empty));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userDto.Name),
                new Claim(JwtRegisteredClaimNames.Email, userDto.Email),
                //new Claim("DateOfJoing", userInfo.DateOfJoing.ToString("yyyy-MM-dd")),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(JwtAppConstants.Issuer,
                JwtAppConstants.Audience,
                claims,
                expires: DateTime.Now.AddHours(JwtAppConstants.ExpiredHour),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

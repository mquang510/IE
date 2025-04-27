using IE.Users.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Users.Application.Queries
{
    public class GetUserLoginQuery(string email, string password) : IRequest<UserDto>
    {
        public string Email = email;
        public string Password = password;
    }
}

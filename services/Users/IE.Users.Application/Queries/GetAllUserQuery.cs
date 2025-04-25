using IE.Users.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Users.Application.Queries
{
    public class GetAllUserQuery : IRequest<List<UserDto>>
    {
    }
}

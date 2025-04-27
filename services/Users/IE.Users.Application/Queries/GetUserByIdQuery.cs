using IE.Users.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Users.Application.Queries
{
    public class GetUserByIdQuery(Guid id): IRequest<UserDto>
    {
        public Guid Id = id;
    }
}

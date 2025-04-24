using IE.Users.Application.Commands;
using IE.Users.Application.DTOs;
using IE.Users.Application.Interfaces;
using IE.Users.Domain.Entities;
using IE.Users.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Users.Application.Data
{
    public class UserService(IUnitOfWork unitOfWork) : IUserService
    {
        private readonly IMediator _mediator;

        public async Task<UserDto> CreateUserAsync(UserDto userDto)
        {
            var cmd = new CreateUserCommand(userDto);
            return await _mediator.Send(cmd);
        }
    }
}

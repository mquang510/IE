using IE.Users.Application.Commands;
using IE.Users.Application.DTOs;
using IE.Users.Application.Interfaces;
using IE.Users.Application.Queries;
using IE.Users.Domain.Interfaces;
using MediatR;

namespace IE.Users.Application.Data
{
    public class UserService(IMediator mediator) : IUserService
    {
        private readonly IMediator _mediator = mediator;

        public async Task<UserDto> CreateUserAsync(UserDto userDto)
        {
            var cmd = new CreateUserCommand(userDto);
            return await _mediator.Send(cmd);
        }

        public async Task<List<UserDto>> GetAllUserAsync()
        {
            var cmd = new GetAllUserQuery();
            return await _mediator.Send(cmd);
        }
    }
}

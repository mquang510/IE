using IE.Users.Application.DTOs;
using MediatR;

namespace IE.Users.Application.Commands
{
    public class CreateUserCommand(UserDto user) : IRequest<UserDto>
    {
        public UserDto User = user;
    }
}

using IE.Users.Application.DTOs;
using MediatR;

namespace IE.Users.Application.Commands
{
    public class CreateUserCommand : IRequest<UserDto>
    {
        public UserDto User { get; }
        public CreateUserCommand(UserDto user)
        {
            User = user;
        }
    }
}

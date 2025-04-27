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

        /// <summary>
        /// Create User Async
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public async Task<UserDto> CreateUserAsync(UserDto userDto)
        {
            var cmd = new CreateUserCommand(userDto);
            return await _mediator.Send(cmd);
        }

        /// <summary>
        /// Get All User Async
        /// </summary>
        /// <returns></returns>
        public async Task<List<UserDto>> GetAllUserAsync()
        {
            var cmd = new GetAllUserQuery();
            return await _mediator.Send(cmd);
        }

        /// <summary>
        /// Get User Login Async
        /// </summary>
        /// <returns></returns>
        public async Task<UserDto> GetUserLoginAsync(string email, string password)
        {
            var cmd = new GetUserLoginQuery(email, password);
            return await _mediator.Send(cmd);
        }

        /// <summary>
        /// Get User By Id Async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<UserDto> GetUserByIdAsync(Guid id)
        {
            var cmd = new GetUserByIdQuery(id);
            return await _mediator.Send(cmd);
        }

        public async Task<UserDto> GetUserByEmailAsync(string email)
        {
            var cmd = new GetUserByEmailQuery(email);
            return await _mediator.Send(cmd);
        }
    }
}

using IE.Users.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Users.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> CreateUserAsync(UserDto userDto);

        Task<List<UserDto>> GetAllUserAsync();

        Task<UserDto> GetUserLoginAsync(string email, string password);

        Task<UserDto> GetUserByIdAsync(Guid id);

        Task<UserDto> GetUserByEmailAsync(string email);
    }
}

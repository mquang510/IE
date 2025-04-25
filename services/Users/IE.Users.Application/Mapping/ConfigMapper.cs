using IE.Shared.Entities;
using AutoMapper;
using IE.Users.Application.DTOs;

namespace IE.Users.Application.Mapping
{
    public class ConfigMapper : Profile
    {
        public ConfigMapper()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}

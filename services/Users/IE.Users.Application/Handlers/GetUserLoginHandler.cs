using AutoMapper;
using IE.Users.Application.DTOs;
using IE.Users.Application.Queries;
using IE.Users.Domain.Interfaces;
using MediatR;

namespace IE.Users.Application.Handlers
{
    public class GetUserLoginHandler(IUnitOfWork uow, IMapper mapper) : IRequestHandler<GetUserLoginQuery, UserDto>
    {
        private readonly IUnitOfWork _uow = uow;
        private readonly IMapper _mapper = mapper;

        public async Task<UserDto> Handle(GetUserLoginQuery request, CancellationToken ct)
        {
            var user = await _uow.Users.FirstOrDefaultAsync(x => x.Email == request.Email && x.Password == request.Password);

            return _mapper.Map<UserDto>(user);
        }
    }
}

using AutoMapper;
using IE.Users.Application.DTOs;
using IE.Users.Application.Queries;
using IE.Users.Domain.Interfaces;
using MediatR;

namespace IE.Users.Application.Handlers
{
    public class GetUserByEmailHandler(IUnitOfWork uow, IMapper mapper) : IRequestHandler<GetUserByEmailQuery, UserDto>
    {
        private readonly IUnitOfWork _uow = uow;
        private readonly IMapper _mapper = mapper;

        public async Task<UserDto> Handle(GetUserByEmailQuery request, CancellationToken ct)
        {
            var user = await _uow.Users.FirstOrDefaultAsync(x => x.Email == request.Email);

            return _mapper.Map<UserDto>(user);
        }
    }
}

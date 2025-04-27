using AutoMapper;
using IE.Users.Application.DTOs;
using IE.Users.Application.Queries;
using IE.Users.Domain.Interfaces;
using MediatR;

namespace IE.Users.Application.Handlers
{
    public class GetUserByIdHandler(IUnitOfWork uow, IMapper mapper) : IRequestHandler<GetUserByIdQuery, UserDto>
    {
        private readonly IUnitOfWork _uow = uow;
        private readonly IMapper _mapper = mapper;

        public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken ct)
        {
            var user = await _uow.Users.FirstOrDefaultAsync(x => x.Id == request.Id);

            return _mapper.Map<UserDto>(user);
        }
    }
}

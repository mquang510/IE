using AutoMapper;
using IE.Shared.Entities;
using IE.Users.Application.Commands;
using IE.Users.Application.DTOs;
using IE.Users.Domain.Interfaces;
using MediatR;

namespace IE.Users.Application.Handlers
{
    public class CreateUserCommandHandler(IUnitOfWork uow, IMapper mapper) : IRequestHandler<CreateUserCommand, UserDto>
    {
        private readonly IUnitOfWork _uow = uow;
        private readonly IMapper _mapper = mapper;

        public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken ct)
        {
            var user = _mapper.Map<User>(request);
            user.Id = Guid.NewGuid();
            await _uow.Users.AddAsync(user);
            await _uow.SaveChangesAsync();

            return _mapper.Map<UserDto>(user);
        }
    }

}

using AutoMapper;
using IE.Users.Application.Commands;
using IE.Users.Application.DTOs;
using IE.Users.Domain.Entities;
using IE.Users.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

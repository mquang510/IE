using AutoMapper;
using IE.Shared.Entities;
using IE.Users.Application.Commands;
using IE.Users.Application.DTOs;
using IE.Users.Application.Queries;
using IE.Users.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Users.Application.Handlers
{
    public class GetAllUserHandler(IUnitOfWork uow, IMapper mapper) : IRequestHandler<GetAllUserQuery, List<UserDto>>
    {
        private readonly IUnitOfWork _uow = uow;
        private readonly IMapper _mapper = mapper;

        public async Task<List<UserDto>> Handle(GetAllUserQuery request, CancellationToken ct)
        {
            var users = await _uow.Users.GetAllAsync();

            return _mapper.Map<List<UserDto>>(users);
        }
    }
}

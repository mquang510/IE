using AutoMapper;
using IE.Products.Application.Commands;
using IE.Products.Application.DTOs;
using IE.Products.Domain.Entity;
using IE.Products.Interfaces;
using IE.Shared.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Products.Application.Handlers
{
    public class CreateProductHandler(IUnitOfWork uow, IMapper mapper) : IRequestHandler<CreateProductCommand, ProductDto>
    {
        private readonly IUnitOfWork _uow = uow;
        private readonly IMapper _mapper = mapper;

        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken ct)
        {
            var product = _mapper.Map<Product>(request.Product);
            await _uow.Products.AddAsync(product);
            await _uow.SaveChangesAsync();

            return _mapper.Map<ProductDto>(product);
        }
    }
}

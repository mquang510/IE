using AutoMapper;
using IE.Products.Application.DTOs;
using IE.Products.Application.Queries;
using IE.Products.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Products.Application.Handlers
{
    public class GetAllProductHandler(IUnitOfWork uow, IMapper mapper): IRequestHandler<GetAllProductQuery, List<ProductDto>>
    {
        private readonly IUnitOfWork _uow = uow;
        private readonly IMapper _mapper = mapper;

        public async Task<List<ProductDto>> Handle(GetAllProductQuery request, CancellationToken ct)
        {
            var products = await _uow.Products.GetAllAsync();

            return _mapper.Map<List<ProductDto>>(products);
        }
    }
}

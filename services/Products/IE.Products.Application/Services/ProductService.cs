using IE.Products.Application.Commands;
using IE.Products.Application.DTOs;
using IE.Products.Application.Interfaces;
using IE.Products.Application.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Products.Application.Services
{
    public class ProductService(IMediator mediator) : IProductService
    {
        private readonly IMediator _mediator = mediator;

        public async Task<ProductDto> CreateProductAsync(ProductDto product)
        {
            var cmd = new CreateProductCommand(product);
            return await _mediator.Send(cmd);
        }

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            var cmd = new GetAllProductQuery();
            return await _mediator.Send(cmd);
        }
    }
}

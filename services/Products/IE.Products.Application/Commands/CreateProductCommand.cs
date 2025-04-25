using IE.Products.Application.DTOs;
using MediatR;

namespace IE.Products.Application.Commands
{
    public class CreateProductCommand(ProductDto product) : IRequest<ProductDto>
    {
        public ProductDto Product = product;
    }
}

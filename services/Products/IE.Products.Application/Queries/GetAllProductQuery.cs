using IE.Products.Application.DTOs;
using IE.Products.Domain.Entity;
using MediatR;

namespace IE.Products.Application.Queries
{
    public class GetAllProductQuery: IRequest<List<ProductDto>>
    {
    }
}

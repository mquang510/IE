using IE.Products.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Products.Application.Interfaces
{
    public interface IProductService
    {
        Task<ProductDto> CreateProductAsync(ProductDto product);
        Task<List<ProductDto>> GetProductsAsync();
    }
}

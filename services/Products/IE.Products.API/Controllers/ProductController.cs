using IE.Products.Application.DTOs;
using IE.Products.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IE.Products.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(IProductService productService) : ControllerBase
    {
        private readonly IProductService _productService = productService;

        [HttpPost(Name = "Create")]
        [Route("product/create")]
        public async Task<ActionResult> Create()
        {
            await _productService.CreateProductAsync(new ProductDto());
            return null;
        }

        [HttpPost(Name = "GetAll")]
        [Route("product/getall")]
        public async Task<ActionResult> GetAll()
        {
            var users = await _productService.GetProductsAsync();
            return null;
        }
    }
}

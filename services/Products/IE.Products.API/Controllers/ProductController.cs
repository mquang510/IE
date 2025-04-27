using IE.Products.Application.DTOs;
using IE.Products.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IE.Products.API.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController(IProductService productService) : ControllerBase
    {
        private readonly IProductService _productService = productService;

        [HttpPost(Name = "Create")]
        [Route("create")]
        public async Task<ActionResult> Create()
        {
            var product = await _productService.CreateProductAsync(new ProductDto());
            return Ok(product);
        }

        [HttpPost(Name = "GetAll")]
        [Route("getall")]
        public async Task<ActionResult> GetAll()
        {
            // var users = await _productService.GetProductsAsync();
            return Ok(new List<ProductDto>());
        }
    }
}

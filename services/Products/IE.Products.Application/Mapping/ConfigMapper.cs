using AutoMapper;
using IE.Products.Application.DTOs;
using IE.Products.Domain.Entity;

namespace IE.Products.Application.Mapping
{
    public class ConfigMapper : Profile
    {
        public ConfigMapper()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}

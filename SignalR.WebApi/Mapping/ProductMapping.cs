using AutoMapper;
using SignalR.DtoLayer;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api;

public class ProductMapping : Profile
{  
    public ProductMapping()
    {
        CreateMap<Product,ResultProductDto>().ReverseMap();
        CreateMap<Product,CreateProductDto>().ReverseMap();
        CreateMap<Product,GetProductDto>().ReverseMap();
        CreateMap<Product,UpdateProductDto>().ReverseMap();
        CreateMap<Product, ResultProductWithCategoriesDto>().ReverseMap();
    }
}

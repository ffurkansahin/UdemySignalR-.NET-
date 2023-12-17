using AutoMapper;
using SignalR.DtoLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api;

public class CategoryMapping : Profile
{
    public CategoryMapping()
    {
        CreateMap<Category,ResultCategoryDto>().ReverseMap();
        CreateMap<Category,GetCategoryDto>().ReverseMap();
        CreateMap<Category,CreateCategoryDto>().ReverseMap();
        CreateMap<Category,UpdateCategoryDto>().ReverseMap();
    }
}

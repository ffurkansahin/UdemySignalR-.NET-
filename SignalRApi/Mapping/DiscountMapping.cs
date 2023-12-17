using AutoMapper;
using SignalR.DtoLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api;

public class DiscountMapping : Profile
{
    public DiscountMapping()
    {
        CreateMap<Discount,ResultDiscountDto>().ReverseMap();
        CreateMap<Discount,CreateDiscountDto>().ReverseMap();
        CreateMap<Discount,UpdateDiscountDto>().ReverseMap();
        CreateMap<Discount,GetDiscountDto>().ReverseMap();
    }
}

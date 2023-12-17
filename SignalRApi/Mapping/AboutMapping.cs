using AutoMapper;
using SignalR.DtoLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api;

public class AboutMapping : Profile
{
    public AboutMapping()
    {
        CreateMap<About,ResultAboutDto>().ReverseMap();
        CreateMap<About,CreateAboutDto>().ReverseMap();
        CreateMap<About,GetAboutDto>().ReverseMap();
        CreateMap<About,UpdateAboutDto>().ReverseMap();
    }
}

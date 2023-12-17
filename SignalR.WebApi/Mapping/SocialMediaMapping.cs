using AutoMapper;
using SignalR.DtoLayer;
using SignalR.EntityLayer;

namespace SignalR.Api;

public class SocialMediaMapping : Profile
{
    public SocialMediaMapping()
    {
        CreateMap<SocialMedia,ResultSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia,GetSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia,UpdateSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia,CreateSocialMediaDto>().ReverseMap();
    }
}

using AutoMapper;
using SignalR.DtoLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api;

public class FeatureMapping : Profile
{
    public FeatureMapping()
    {
        CreateMap<Feature,ResultFeatureDto>().ReverseMap();
        CreateMap<Feature,GetFeatureDto>().ReverseMap();
        CreateMap<Feature,CreateFeatureDto>().ReverseMap();
        CreateMap<Feature,UpdateFeatureDto>().ReverseMap();
    }
}

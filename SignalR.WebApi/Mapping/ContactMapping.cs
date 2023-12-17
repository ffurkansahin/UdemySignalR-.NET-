using AutoMapper;
using SignalR.DtoLayer;
using SignalR.EntityLayer;

namespace SignalR.Api;

public class ContactMapping : Profile
{

    public ContactMapping()
    {
        CreateMap<Contact,ResultContactDto>().ReverseMap();
        CreateMap<Contact,UpdateContactDto>().ReverseMap();
        CreateMap<Contact,CreateContactDto>().ReverseMap();
        CreateMap<Contact,GetContactDto>().ReverseMap();
        
    }
}

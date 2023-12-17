using AutoMapper;
using SignalR.DtoLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api;

public class BookingMapping : Profile
{
    public BookingMapping()
    {
        CreateMap<Booking,ResultBookingDto>().ReverseMap();
        CreateMap<Booking,CreateBookingDto>().ReverseMap();
        CreateMap<Booking,GetBookingDto>().ReverseMap();
        CreateMap<Booking,UpdateBookingDto>().ReverseMap();
    }

}

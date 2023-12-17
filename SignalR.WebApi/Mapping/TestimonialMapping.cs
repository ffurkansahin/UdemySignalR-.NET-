using AutoMapper;
using SignalR.DtoLayer;
using SignalR.EntityLayer;

namespace SignalR.Api;

public class TestimonialMapping : Profile
{
    public TestimonialMapping()
    {
        CreateMap<Testimonial,ResultTestimonialDto>().ReverseMap();
        CreateMap<Testimonial,UpdateTestimonialDto>().ReverseMap();
        CreateMap<Testimonial,CreateTestimonialDto>().ReverseMap();
        CreateMap<Testimonial,GetTestimonialDto>().ReverseMap();
    }
}

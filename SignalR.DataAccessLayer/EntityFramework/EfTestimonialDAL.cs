using SignalR.EntityLayer;

namespace SignalR.DataAccessLayer;

public class EfTestimonialDAL : IGenericRepository<Testimonial>, ITestimonialDAL
{
    public EfTestimonialDAL(SignalRContext context) : base(context)
    {
    }
}
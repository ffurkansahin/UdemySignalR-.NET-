using SignalR.DataAccessLayer;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer;

public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialDAL testimonialDAL;

    public TestimonialManager(ITestimonialDAL testimonialDAL)
    {
        this.testimonialDAL = testimonialDAL;
    }

    public void TAdd(Testimonial entity)
    {
        testimonialDAL.Add(entity);
    }

    public void TDelete(Testimonial entity)
    {
        testimonialDAL.Delete(entity);
    }

    public Testimonial TGetById(int id)
    {
        return testimonialDAL.GetById(id);
    }

    public List<Testimonial> TGetList()
    {
        return testimonialDAL.GetList();
    }

    public void TUpdate(Testimonial entity)
    {
        testimonialDAL.Update(entity);
    }
}

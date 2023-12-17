using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer;

public class EfBookingDAL : IGenericRepository<Booking>, IBookingDAL
{
    public EfBookingDAL(SignalRContext context) : base(context)
    {
    }
}

using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer;

public class EfDiscountDAL : IGenericRepository<Discount>, IDiscountDAL
{
    public EfDiscountDAL(SignalRContext context) : base(context)
    {
    }
}

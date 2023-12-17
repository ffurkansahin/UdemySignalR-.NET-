using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer;

public class EfProductDAL : IGenericRepository<Product>, IProductDAL
{
    public EfProductDAL(SignalRContext context) : base(context)
    {
    }
}

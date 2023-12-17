using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer;

public class EfAboutDAL : IGenericRepository<About> , IAboutDAL
{
    public EfAboutDAL(SignalRContext context) : base(context)
    {
    }
}

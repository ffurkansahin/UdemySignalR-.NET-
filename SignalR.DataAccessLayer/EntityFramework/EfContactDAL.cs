using SignalR.EntityLayer;

namespace SignalR.DataAccessLayer;

public class EfContactDAL : IGenericRepository<Contact>, IContactDAL
{
    public EfContactDAL(SignalRContext context) : base(context)
    {
    }
}

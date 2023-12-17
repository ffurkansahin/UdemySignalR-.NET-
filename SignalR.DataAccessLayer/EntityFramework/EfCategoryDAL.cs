using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer;

public class EfCategoryDAL : IGenericRepository<Category>, ICategoryDAL
{
    public EfCategoryDAL(SignalRContext context) : base(context)
    {
    }
}

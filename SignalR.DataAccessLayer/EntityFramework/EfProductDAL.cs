using Microsoft.EntityFrameworkCore;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer;

public class EfProductDAL : IGenericRepository<Product>, IProductDAL
{
    public EfProductDAL(SignalRContext context) : base(context)
    {
    }

    public List<Product> GetProductsWithCategories()
    {
        var context = new SignalRContext();
        var values = context.Products.Include(i=>i.Category).ToList();
        return values;
    }
}

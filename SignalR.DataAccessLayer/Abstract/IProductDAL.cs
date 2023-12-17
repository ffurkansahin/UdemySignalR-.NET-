using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer;

public interface IProductDAL : IGenericDAL<Product>
{
    List<Product> GetProductsWithCategories();
}

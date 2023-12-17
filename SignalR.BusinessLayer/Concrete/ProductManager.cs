using SignalR.DataAccessLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer;

public class ProductManager : IProductService
{
    private readonly IProductDAL productDAL;

    public ProductManager(IProductDAL productDAL)
    {
        this.productDAL = productDAL;
    }

    public void TAdd(Product entity)
    {
        productDAL.Add(entity);
    }

    public void TDelete(Product entity)
    {
        productDAL.Delete(entity);
    }

    public Product TGetById(int id)
    {
        return productDAL.GetById(id);
    }

    public List<Product> TGetList()
    {
        return productDAL.GetList();
    }

    public List<Product> TGetProductsWithCategories()
    {
        return productDAL.GetProductsWithCategories();
    }

    public void TUpdate(Product entity)
    {
        productDAL.Update(entity);
    }
}

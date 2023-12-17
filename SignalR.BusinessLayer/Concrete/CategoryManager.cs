using SignalR.DataAccessLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDAL categoryDAL;

    public CategoryManager(ICategoryDAL categoryDAL)
    {
        this.categoryDAL = categoryDAL;
    }

    public void TAdd(Category entity)
    {
        categoryDAL.Add(entity);
    }

    public void TDelete(Category entity)
    {
        categoryDAL.Delete(entity);
    }

    public Category TGetById(int id)
    {
        return categoryDAL.GetById(id);
    }

    public List<Category> TGetList()
    {
        return categoryDAL.GetList();
    }

    public void TUpdate(Category entity)
    {
        categoryDAL.Update(entity);
    }
}

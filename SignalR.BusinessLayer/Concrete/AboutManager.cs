using SignalR.DataAccessLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer;

public class AboutManager : IAboutService
{
    private readonly IAboutDAL aboutDAL;

    public AboutManager(IAboutDAL aboutDAL)
    {
        this.aboutDAL = aboutDAL;
    }

    public void TAdd(About entity)
    {
        aboutDAL.Add(entity);
    }

    public void TDelete(About entity)
    {
        aboutDAL.Delete(entity);
    }

    public About TGetById(int id)
    {
        return aboutDAL.GetById(id);
    }

    public List<About> TGetList()
    {
        return aboutDAL.GetList();
    }

    public void TUpdate(About entity)
    {
        aboutDAL.Update(entity);
    }
}

using SignalR.DataAccessLayer;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer;

public class ContactManager : IContactService
{
    private readonly IContactDAL contactDAL;

    public ContactManager(IContactDAL contactDAL)
    {
        this.contactDAL = contactDAL;
    }

    public void TAdd(Contact entity)
    {
        contactDAL.Add(entity);
    }

    public void TDelete(Contact entity)
    {
        contactDAL.Delete(entity);
    }

    public Contact TGetById(int id)
    {
        return contactDAL.GetById(id);
    }

    public List<Contact> TGetList()
    {
        return contactDAL.GetList();
    }

    public void TUpdate(Contact entity)
    {
        contactDAL.Update(entity);
    }
}

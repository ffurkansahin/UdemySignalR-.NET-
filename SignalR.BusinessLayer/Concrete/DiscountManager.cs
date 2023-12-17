using SignalR.DataAccessLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer;

public class DiscountManager : IDiscountService

{
    private readonly IDiscountDAL discountDAL;

    public DiscountManager(IDiscountDAL discountDAL)
    {
        this.discountDAL = discountDAL;
    }

    public void TAdd(Discount entity)
    {
        discountDAL.Add(entity);
    }

    public void TDelete(Discount entity)
    {
        discountDAL.Delete(entity);
    }

    public Discount TGetById(int id)
    {
        return discountDAL.GetById(id);
    }

    public List<Discount> TGetList()
    {
        return discountDAL.GetList();
    }

    public void TUpdate(Discount entity)
    {
        discountDAL.Update(entity);
    }
}

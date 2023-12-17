using SignalR.DataAccessLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer;

public class BookingManager : IBookingService
{
    private readonly IBookingDAL bookingDAL;

    public BookingManager(IBookingDAL bookingDAL)
    {
        this.bookingDAL = bookingDAL;
    }

    public void TAdd(Booking entity)
    {
        bookingDAL.Add(entity);
    }

    public void TDelete(Booking entity)
    {
        bookingDAL.Delete(entity);
    }

    public Booking TGetById(int id)
    {
        return bookingDAL.GetById(id);
    }

    public List<Booking> TGetList()
    {
        return bookingDAL.GetList();
    }

    public void TUpdate(Booking entity)
    {
        bookingDAL.Update(entity);
    }
}


using System.Collections.Frozen;

namespace SignalR.DataAccessLayer;

public class IGenericRepository<T> : IGenericDAL<T> where T : class
{
    private readonly SignalRContext _context;

    public IGenericRepository(SignalRContext context)
    {
        _context = context;
    }

    public void Add(T entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public List<T> GetList()
    {
        return _context.Set<T>().ToList();
    }

    public void Update(T entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }
}

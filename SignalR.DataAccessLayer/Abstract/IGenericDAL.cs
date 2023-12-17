namespace SignalR.DataAccessLayer;

public interface IGenericDAL<T> where T : class
{

    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T GetById(int id);
    List<T> GetList();
}

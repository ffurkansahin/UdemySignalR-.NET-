﻿namespace SignalR.BusinessLayer;

public interface IGenericService<T> where T : class
{
    void TAdd(T entity);
    void TDelete(T entity);
    void TUpdate(T entity);
    T TGetById(int id);
    List<T> TGetList();
}

namespace Contracts;

public interface IRepository<T>
{
    void Add(T item);

    List<T> GetAll();

    T? GetByIndex(int index);
}
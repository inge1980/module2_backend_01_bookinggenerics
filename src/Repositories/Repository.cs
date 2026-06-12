using Contracts;
namespace Repositories;

public class Repository<T> : IRepository<T>
    where T : class
{
    private readonly List<T> items = new();

    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> GetAll()
    {
        return items;
    }

    public T? GetByIndex(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            return null;
        }

        return items[index];
    }
}
using WebMVC6.Models;

namespace WebMVC6.Repository.IRepositories
{
    public interface IAllRepositories<T> where T  : class

    {   
        IEnumerable<T> GetAll();
        T GetItem(dynamic id);
        bool AddItem(T item);   
        bool UpdateItem(T item);
        bool DeleteItem(T item);
    }
}

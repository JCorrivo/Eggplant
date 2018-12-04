using System.Linq;

namespace Eggplant.Application.Interfaces.Persistence
{
    public interface IRepository<T>
    {
        T Get(int id);

        void Add(T entity);

        void Remove(T entity);
    }
}
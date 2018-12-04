using System.Linq;

namespace Eggplant.Application.Interfaces.Persistence
{
    public interface IReadOnlyRepository<T>
    {
         IQueryable<T> GetAll();
    }
}
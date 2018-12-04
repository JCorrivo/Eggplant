using System.Linq;
using Eggplant.Application.Interfaces.Persistence;
using Eggplant.Domain.Common;

namespace Eggplant.Persistence
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly IEggplantContext _dbContext;

        public Repository(IEggplantContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>()
                .Add(entity);
        }

        public T Get(int id)
        {
            return _dbContext.Set<T>()
                .Single(p => p.Id == id);
        }

        public void Remove(T entity)
        {
            _dbContext.Set<T>()
                .Remove(entity);
        }
    }
}
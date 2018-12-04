using System.Linq;
using Eggplant.Application.Interfaces.Persistence;
using Eggplant.Domain.Common;

namespace Eggplant.Persistence
{
    public class ReadOnlyRepository<T> : IReadOnlyRepository<T>
        where T : class, IEntity
    {
        private readonly IEggplantContext _dbContext;

        public ReadOnlyRepository(IEggplantContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }
    }
}
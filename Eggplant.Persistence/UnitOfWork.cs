using Eggplant.Application.Interfaces.Persistence;

namespace Eggplant.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IEggplantContext _dbContext;

        public UnitOfWork(IEggplantContext dbContext)
        {
            _dbContext = dbContext;

        }

        public void Save()
        {
            _dbContext.Save();
        }
    }
}
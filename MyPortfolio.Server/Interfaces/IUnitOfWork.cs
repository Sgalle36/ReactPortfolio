using MyPortfolio.Server.Data.Models;

namespace MyPortfolio.Server.Interfaces
{
    public interface IUnitOfWork
    {
        // models 
        public IGenericRepository<Project> Project { get; }

        // save changes to the data source
        int Commit();

        Task<int> CommitAsync();
    }
}

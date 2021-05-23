using CoreBoilerplate.Domain;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoreBoilerplate.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;

        Task<int> CommitAsync(CancellationToken cancellationToken);

        Task Rollback();
    }
}
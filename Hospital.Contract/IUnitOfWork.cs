using Hospital.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Contract
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync(CancellationToken cancellationToken);
        IGenericRepository<T> GenericRepository<T>() where T : BaseEntity;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

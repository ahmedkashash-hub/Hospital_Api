using Hospital.Contracts;
using Hospital.Domain.Common;
using Phnx.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Contact
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync(CancellationToken cancellationToken);
        IGenericRepository<T> GenericRepository<T>() where T : BaseEntity;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }

}

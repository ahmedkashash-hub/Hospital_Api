using Hospital.Contract;
using Hospital.Domain.Common;
using Hospital.Infrastructure.Persistence.Database;
using Hospital.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Infrastructure.Persistence
{
    
        public class UnitOfWork(HospitalDbContex dbContext) : IUnitOfWork
        {
            public IGenericRepository<T> GenericRepository<T>() where T : BaseEntity
                => new GenericRepository<T>(dbContext);
            public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
                => await dbContext.SaveChangesAsync(cancellationToken);

            public async Task<int> CommitAsync(CancellationToken cancellationToken)
            {
                await using var transaction = await dbContext.Database.BeginTransactionAsync(cancellationToken);
                try
                {
                    int result = await dbContext.SaveChangesAsync(true, cancellationToken);
                    await transaction.CommitAsync(cancellationToken);
                    return result;
                }
                catch
                {
                    await transaction.RollbackAsync(cancellationToken);
                    throw;
                }
            }
        }
    
}

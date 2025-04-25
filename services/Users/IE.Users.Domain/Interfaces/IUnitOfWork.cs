using IE.Shared.Entities;
using IE.Shared.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Users.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

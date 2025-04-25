using IE.Shared.Entities;
using IE.Shared.Persistence;
using IE.Users.Domain.Interfaces;

namespace IE.Users.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IRepository<User> Users { get; }

        public UnitOfWork(AppDbContext context, IRepository<User> users)
        {
            _context = context;
            Users = users;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

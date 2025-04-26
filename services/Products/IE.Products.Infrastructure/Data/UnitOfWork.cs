using IE.Products.Domain.Entity;
using IE.Products.Interfaces;
using IE.Shared.Interfaces;

namespace IE.Products.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IRepository<Product> Products { get; }

        public UnitOfWork(AppDbContext context, IRepository<Product> products)
        {
            _context = context;
            Products = products;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

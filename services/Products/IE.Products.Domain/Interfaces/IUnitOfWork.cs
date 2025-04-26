using IE.Products.Domain.Entity;
using IE.Shared.Interfaces;

namespace IE.Products.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Product> Products { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

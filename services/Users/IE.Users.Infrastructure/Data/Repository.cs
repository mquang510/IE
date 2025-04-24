using IE.Users.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IE.Users.Infrastructure.Data
{
    public class Repository<TEntity>(AppDbContext dbContext) : IRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _dbContext = dbContext;
        protected readonly DbSet<TEntity> _dbSet = dbContext.Set<TEntity>();

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        /// <summary>
        /// Add Async
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
        /// <summary>
        /// First Or Default Async
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }
        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }
        /// <summary>
        /// Get All Async
        /// </summary>
        /// <returns></returns>
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
        /// <summary>
        /// Any
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Any(predicate);
        }
        /// <summary>
        /// Count
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Count(predicate);
        }
    }
}

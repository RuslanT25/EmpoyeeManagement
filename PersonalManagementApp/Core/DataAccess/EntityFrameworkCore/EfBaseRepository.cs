using Core.Entitiy.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFrameworkCore
{
    public class EfBaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        private readonly TContext _context;
        public EfBaseRepository(TContext context)
        {
            _context = context;
        }

        private DbSet<TEntity> DbSet => _context.Set<TEntity>();

        public async Task AddAsync(TEntity entity)
        {
            await DbSet.AddAsync(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => DbSet.Remove(entity));
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            IQueryable<TEntity> queryable = DbSet;
            return await queryable.FirstOrDefaultAsync(filter);
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> queryable = DbSet;
            if (filter != null)
                return await queryable.Where(filter).ToListAsync();
            
                return await queryable.ToListAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => DbSet.Update(entity));
        }
    }
}

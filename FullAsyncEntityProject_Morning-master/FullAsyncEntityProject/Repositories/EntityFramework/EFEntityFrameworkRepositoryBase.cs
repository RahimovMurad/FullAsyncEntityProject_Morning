using FullAsyncEntityProject.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FullAsyncEntityProject.Repositories.EntityFramework
{
    public class EFEntityFrameworkRepositoryBase<TEntity, TContext>
        : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext
    {

        private readonly TContext _context;

        public EFEntityFrameworkRepositoryBase(TContext context)
        {
            _context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            await _context.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            return (await _context.SaveChangesAsync()) > 0;
        }
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return updatedEntity.Entity;
        }

        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _context.Set<TEntity>().SingleOrDefaultAsync(filter);
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ?
                await _context.Set<TEntity>().ToListAsync() :
                await _context.Set<TEntity>().Where(filter).ToListAsync();
        }

    }
}

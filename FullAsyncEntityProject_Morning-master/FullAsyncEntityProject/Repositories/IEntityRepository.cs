using FullAsyncEntityProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FullAsyncEntityProject.Repositories
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //x=>x.Name="Elvin"
        Task<T?> GetAsync(Expression<Func<T, bool>> filter);
        Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter=null);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}

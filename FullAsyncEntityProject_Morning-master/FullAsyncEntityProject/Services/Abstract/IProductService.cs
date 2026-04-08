using FullAsyncEntityProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FullAsyncEntityProject.Services.Abstract
{
    public interface IProductService
    {
        Task<Product?> GetAsync(Expression<Func<Product, bool>> filter);
        Task<List<Product>> GetListAsync(Expression<Func<Product, bool>> filter = null);
        Task<Product> AddAsync(Product entity);
        Task<Product> UpdateAsync(Product entity);
        Task<bool> DeleteAsync(Product entity);
    }
}

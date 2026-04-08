using FullAsyncEntityProject.DataAccess.Abstraction;
using FullAsyncEntityProject.Entities;
using FullAsyncEntityProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FullAsyncEntityProject.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task<Product> AddAsync(Product entity)
        {
            return await _productDal.AddAsync(entity);
        }

        public Task<bool> DeleteAsync(Product entity)
        {
            return _productDal.DeleteAsync(entity);
        }

        public Task<Product?> GetAsync(Expression<Func<Product, bool>> filter)
        {
            return _productDal.GetAsync(filter);
        }

        public Task<List<Product>> GetListAsync(Expression<Func<Product, bool>> filter = null)
        {
            return _productDal.GetListAsync(filter);
        }

        public Task<Product> UpdateAsync(Product entity)
        {
            return _productDal.UpdateAsync(entity);
        }
    }
}

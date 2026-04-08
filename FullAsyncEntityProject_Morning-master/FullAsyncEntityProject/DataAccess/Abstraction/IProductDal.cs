using FullAsyncEntityProject.Entities;
using FullAsyncEntityProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullAsyncEntityProject.DataAccess.Abstraction
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}

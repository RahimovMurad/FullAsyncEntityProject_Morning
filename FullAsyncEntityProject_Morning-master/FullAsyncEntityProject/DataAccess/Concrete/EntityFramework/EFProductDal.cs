using FullAsyncEntityProject.DataAccess.Abstraction;
using FullAsyncEntityProject.Entities;
using FullAsyncEntityProject.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullAsyncEntityProject.DataAccess.Concrete.EntityFramework
{
    public class EFProductDal:EFEntityFrameworkRepositoryBase<Product,StepDBContext>,IProductDal
    {
        public EFProductDal(StepDBContext context)
            :base(context)
        {
            
        }
    }
}

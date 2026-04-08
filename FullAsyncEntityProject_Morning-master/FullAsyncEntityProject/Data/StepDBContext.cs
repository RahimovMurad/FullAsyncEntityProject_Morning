using FullAsyncEntityProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullAsyncEntityProject.DataAccess
{
    public class StepDBContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               .UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=StepDB6;Integrated Security=True;Trust Server Certificate=False;");
        }
    }
}

using FullAsyncEntityProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullAsyncEntityProject.Entities
{
    public class Category : IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
    }
}

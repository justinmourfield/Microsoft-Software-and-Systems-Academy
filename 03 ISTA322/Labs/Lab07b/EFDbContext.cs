using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;
using System.Data.Entity;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;

namespace SportsStore.Domain.Concrete
{
    class EFDbContext:System.Data.Entity.DbContext
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
        
    }
}

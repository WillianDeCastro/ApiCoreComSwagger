using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreComSqlServer.Contexts
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {

        }
        public ProductContext(DbContextOptions<ProductContext> opt) : base(opt)
        {

        }

        //a propriedade deve ser o mesmo nome da tabela
        public virtual DbSet<Products> Products { get; set; }

    }
}

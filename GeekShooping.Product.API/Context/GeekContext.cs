using GeekShooping.Product.API.Model;
using GeekShooping.Product.API.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace GeekShooping.Product.API.Context
{
    public class GeekContext : DbContext
    {
        public GeekContext()
        {

        }
        public GeekContext(DbContextOptions<GeekContext> options) : base(options)
        {

        }

        public DbSet<BaseEntity> Entidade { get; set; }
        public DbSet<ProductModel> Products { get; set; }
    }
}

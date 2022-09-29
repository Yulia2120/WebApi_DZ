using Microsoft.EntityFrameworkCore;

namespace WebApi_DZ.Models
{
    public class ProductsContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public ProductsContext(DbContextOptions<ProductsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

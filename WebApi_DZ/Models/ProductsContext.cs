using Microsoft.EntityFrameworkCore;

namespace WebApi_DZ.Models
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductsContext(DbContextOptions<ProductsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

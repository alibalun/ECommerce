using Microsoft.EntityFrameworkCore;

namespace ECommerce.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

    }
}

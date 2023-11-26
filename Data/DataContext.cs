using Microsoft.EntityFrameworkCore;
using threadShopWebApi.Models;

namespace threadShopWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Authentification> Authentifications { get; set; }
        public DbSet<Delivery> Deliverys { get; set; }
    }
}

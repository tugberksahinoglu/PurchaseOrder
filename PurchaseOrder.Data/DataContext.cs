using Microsoft.EntityFrameworkCore;
using PurchaseOrder.Model;

namespace PurchaseOrder.Data {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseInMemoryDatabase("InMemoryDb");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using CrmAzureGUI.Model;
namespace CrmAzureGUI.Data
{
    class CrmAzureDbContext : DbContext
    {
        public DbSet<Model.Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                connectionString: "Server = tcp:laza.database.windows.net, 1433; Initial Catalog = CrmAzureGUI;" +
                " Persist Security Info = False; User ID = illarios23; Password =2020@lari2020; MultipleActiveResultSets = False;" +
                " Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.Customer>();

            modelBuilder.Entity<Model.Customer>()
                .Property(c => c.FirstName)
                .IsRequired();

            modelBuilder.Entity<Model.Customer>()
                .Property(c => c.LastName)
                .IsRequired();

            modelBuilder.Entity<Order>();
            modelBuilder.Entity<Product>();
            // works on EF Core 5.0
            //modelBuilder.Entity<Order>().HasMany(o => o.Products).WitMany()
            // Many-to-many: works on EF Core 3.x
            //modelBuilder.Entity<OrderProduct>().HasKey(op => new { op.OrderId, op.ProductId });
        }
    }
}

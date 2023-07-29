using GeneralStore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GeneralStore.Data.Context
{
    public class GStoreDbContext : DbContext
    {
        public GStoreDbContext(DbContextOptions<GStoreDbContext> options) : base(options) { }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
    }
}
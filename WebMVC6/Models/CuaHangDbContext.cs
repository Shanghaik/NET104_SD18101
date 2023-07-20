using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace WebMVC6.Models
{
    public class CuaHangDbContext:DbContext
    {
        public CuaHangDbContext() { }
        public CuaHangDbContext(DbContextOptions options):base(options) { }
        
        public DbSet<Role> Roles { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartDetails> CartDetailss { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SHANGHAIK;Initial Catalog=NET104_18101_2;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace WebMVC6.Models
{
    public class CuaHangDbContext:DbContext
    {
        public CuaHangDbContext() { }
        public CuaHangDbContext(DbContextOptions options):base(options) { }
        
        DbSet<Role> Roles { get; set; }
        DbSet<Bill> Bills { get; set; }
        DbSet<Cart> Carts { get; set; }
        DbSet<Bill> Products { get; set; }
        DbSet<CartDetails> CartDetailss { get; set; }
        DbSet<BillDetails> BillDetails { get; set; }
        DbSet<User> Users { get; set; }
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

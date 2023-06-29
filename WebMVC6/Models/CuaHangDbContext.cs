using Microsoft.EntityFrameworkCore;

namespace WebMVC6.Models
{
    public class CuaHangDbContext:DbContext
    {
        public CuaHangDbContext() { }
        public CuaHangDbContext(DbContextOptions options):base(options) { }
        
        DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SHANGHAIK;Initial Catalog=NET104_18101;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

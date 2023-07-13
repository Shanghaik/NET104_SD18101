using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMVC6.Models;

namespace WebMVC6.Configurations
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.RoleName).IsRequired().
               HasColumnType("nvarchar(50)");
            builder.HasOne<Role>().WithMany(p => p.Roles).
                HasForeignKey(p => p.ReportId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}

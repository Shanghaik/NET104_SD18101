using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMVC6.Models;

namespace WebMVC6.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(p => p.UserRole).WithMany(q => q.Users).
                HasForeignKey(p => p.RoleId);
        }
    }
}

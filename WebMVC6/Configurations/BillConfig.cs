using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMVC6.Models;

namespace WebMVC6.Configurations
{
    public class BillConfig : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasOne(p=>p.User).WithMany(q=>q.Bills).
                HasForeignKey(x=>x.UserId).
                HasConstraintName("FK_Bill_User");
        }
    }
}

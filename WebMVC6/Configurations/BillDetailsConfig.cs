using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMVC6.Models;

namespace WebMVC6.Configurations
{
    public class BillDetailsConfig : IEntityTypeConfiguration<BillDetails>
    {
        public void Configure(EntityTypeBuilder<BillDetails> builder)
        {
            // Khóa chính
            builder.HasKey(x => x.Id);
            // Thiết lập khóa ngoại
            builder.HasOne(p => p.Product).
                WithMany(q => q.BillDetails).
                HasForeignKey(p => p.ProductID).
                HasConstraintName("FK_BillDetails_Product");
            // => Khóa ngoại nối từ bảng BillDetails
            // tới bảng product thông qua ProductID
            builder.HasOne(p => p.Bill).
                WithMany(q => q.Details).
                HasForeignKey(p => p.BillId).
                HasConstraintName("FK_BillDetails_Bill");

        }
    }
}

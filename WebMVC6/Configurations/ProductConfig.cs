using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMVC6.Models;

namespace WebMVC6.Configurations
{
    public class ProductConfig
        : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Thực hiện các thiết lập trên bảng
            builder.HasKey(x =>  x.Id); // Khóa chính
            // Thiết lập tên cột và kiểu dữ liệu
            builder.Property(x => x.Name).
                HasColumnName("Ten").
                HasColumnType("nvarchar(100)").IsRequired();
            // Tương đương với Ten nvarchar(100)
            builder.Property(x => x.Description).
                HasColumnName("Mota").IsUnicode(true).
                HasMaxLength(500).IsFixedLength().
                IsRequired();
            // Tương đương với Mota nvarchar(500)

        }
    }
}

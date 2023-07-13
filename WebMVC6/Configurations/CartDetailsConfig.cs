using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMVC6.Models;

namespace WebMVC6.Configurations
{
    public class CartDetailsConfig : IEntityTypeConfiguration<CartDetails>
    {
        public void Configure(EntityTypeBuilder<CartDetails> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(p=>p.Cart).WithMany(q=>q.Details).
                HasForeignKey(x=>x.UserId);
            builder.HasOne(p => p.Product).WithMany(q => q.CartDetails).
                HasForeignKey(x => x.ProductId);
        }
    }
}

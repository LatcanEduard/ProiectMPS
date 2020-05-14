
using Microsoft.EntityFrameworkCore;
using Core.Entities.OrderAggregate;


namespace Infrastructure.Data.Config
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrderItem> builder)
        {
            builder.OwnsOne(i => i.ItemOrdered, io => { io.WithOwner(); });
            builder.Property(i => i.Price).HasColumnType("decimar(18,2)");
        }
    }
}
using DBShoping.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBShoping.Configures;

public class OrderDetailConfiguration:IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.HasKey(detail => new { detail.OrderId, detail.ProductId });

        builder.HasOne(OrderDetail => OrderDetail.Order)
            .WithMany(order => order.OrderDetails)
            .HasForeignKey(detail => detail.OrderId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(OrderDetail => OrderDetail.Product)
            .WithMany(product => product.OrderDetails)
            .HasForeignKey(detail => detail.ProductId);
    }
}
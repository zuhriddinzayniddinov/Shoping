using DBShoping.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBShoping.Configures;

public class OrderConfiguration:IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(order => order.OrderId);

        builder.HasOne(Order => Order.Shipper)
            .WithMany(shipper => shipper.Orders)
            .HasForeignKey(order => order.ShipperId);

        builder.HasOne(Order => Order.Customer)
            .WithMany(customer => customer.Orders)
            .HasForeignKey(order => order.CustomerId);

    }
}
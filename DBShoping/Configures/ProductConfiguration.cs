using DBShoping.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBShoping.Configures;

public class ProductConfiguration:IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(Productem => Productem.ProductId);
        
      builder.HasOne(Productm => Productm.Supplier)
          .WithMany(supplier => supplier.Products)
          .HasForeignKey(product => product.SupplierId)
          .OnDelete(DeleteBehavior.SetNull);
      
      builder.HasOne(Productm => Productm.Category)
          .WithMany(category =>  category.Products)
          .HasForeignKey(product => product.CategoryId)
          .OnDelete(DeleteBehavior.SetNull);

      builder.Property(product => product.ProductName)
          .IsRequired()
          .HasMaxLength(20);
    }
}
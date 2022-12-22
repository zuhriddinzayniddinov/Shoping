using DBShoping.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBShoping.Configures;

public class EmployeeConfiguration:IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(employee => employee.EmployeeId);
        
        builder.HasMany(Employee => Employee.Orders)
            .WithOne(order => order.Employee)
            .HasForeignKey(order => order.EmployeeId);
    }
}
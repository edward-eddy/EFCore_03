using EFCore_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_03.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(E => E.Id).UseIdentityColumn(10, 10);
            builder.Property(E => E.Salary).HasColumnType("money");
            builder.Property(E => E.Address).HasMaxLength(100);

            builder.HasOne(E => E.WorkAt)
                   .WithMany(D => D.Employees)
                   .HasForeignKey(E => E.DeptId);

        }
    }
}

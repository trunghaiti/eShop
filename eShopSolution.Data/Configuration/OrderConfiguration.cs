using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.OrderDate).IsRequired().HasDefaultValue(DateTime.Now);

            builder.Property(x => x.ShipName).IsRequired().HasMaxLength(250);

            builder.Property(x => x.ShipAddress).IsRequired().HasMaxLength(500);

            builder.Property(x => x.ShipPhoneNumber).IsRequired().IsUnicode(false).HasMaxLength(50);

            builder.Property(x => x.ShipEmail).IsUnicode(false).HasMaxLength(50);
        }
    }
}

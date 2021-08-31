﻿using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            
            builder.Property(x => x.Price).IsRequired(true);

            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValue(DateTime.Now);

            builder.Property(x => x.Stock).IsRequired(true).HasDefaultValue(0);

            builder.Property(x => x.ViewCount).IsRequired(true).HasDefaultValue(0);

            builder.Property(x => x.OriginalPrice).IsRequired(true).HasDefaultValue(0);

        
        }
    }
}

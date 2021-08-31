using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configuration
{
    public class ProductTranslationConfiguration : IEntityTypeConfiguration<ProductTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            builder.ToTable("ProductTranslation");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250);

            builder.Property(x => x.Description).IsRequired().HasMaxLength(250);
            
            builder.Property(x => x.Detail).IsRequired().HasMaxLength(250);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(250);

            builder.Property(x => x.SeoTitle).IsRequired().IsUnicode(false).HasMaxLength(250);

            builder.HasOne(x => x.Product).WithMany(x => x.ProductTranslations).HasForeignKey(x=>x.ProductId);
            builder.HasOne(x => x.Language).WithMany(x => x.ProductTranslations).HasForeignKey(x => x.LanguageId);

        }
    }
}

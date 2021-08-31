using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configuration
{
    public class CategoryTranslationConfiguration : IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            builder.ToTable("CategoryTranslation");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(250);

            builder.Property(x => x.SeoDescription).HasMaxLength(250);

            builder.Property(x => x.SeoAlias).HasMaxLength(250);

            builder.Property(x => x.LanguageId).IsRequired().IsUnicode(false).HasMaxLength(5);

            builder.HasOne(x => x.Category).WithMany(x => x.CategoryTranslations);
            builder.HasOne(x => x.Language).WithMany(x => x.CategoryTranslations);
        }
    }
}
